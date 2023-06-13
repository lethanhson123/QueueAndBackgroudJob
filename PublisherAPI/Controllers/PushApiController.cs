using BusinessServices.Constants;
using BusinessServices.Models.MessageQueueModel;
using BusinessServices.Services;
using Microsoft.AspNetCore.Mvc;
using NLog;
using QueueEngine;
using QueueEngine.Behaviors;
using QueueEngine.Models.QueueSetting;
using Utilities;

namespace PublisherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PushApiController : ControllerBase
    {
        private readonly List<IQueuePublisher<SyncOrderIDQueueModel>> _publishers;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public PushApiController()
        {
            _publishers = CreatePublisher();
        }

        private List<IQueuePublisher<SyncOrderIDQueueModel>> CreatePublisher()
        {
            try
            {
                logger.Info("Create SyncOrderQueue Publisher.");
                List<IQueuePublisher<SyncOrderIDQueueModel>> queuePublishers = new List<IQueuePublisher<SyncOrderIDQueueModel>>();
                var providerSetting = AppSettingsConstant.Application.Services["awsSQS"]["Provider"];
                var provider = Common.ParseEnum<QueueProvider>(providerSetting);
                switch (provider)
                {
                    case QueueProvider.AWS:

                        var amazonSetting = new AmazonQueueSetting();
                        amazonSetting.RegionEndpoint = AppSettingsConstant.Application.Services["awsSQS"]["RegionEndpoint"];
                        amazonSetting.AccessKey = AppSettingsConstant.Application.Services["awsSQS"]["AccessKey"];
                        amazonSetting.SecretKey = AppSettingsConstant.Application.Services["awsSQS"]["SecretKey"];
                        amazonSetting.QueueUrl = AppSettingsConstant.Application.Services["awsSQS"]["QueueUrl"];

                        queuePublishers.Add(QueueEngineFactory.CreatePublisher<SyncOrderIDQueueModel>(provider, amazonSetting, ""));
                        break;
                }

                return queuePublishers;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }

            return default;
        }

        [HttpPost]
        [Route("PushSyncOrder")]
        public async Task<Dictionary<string, object>> PushSyncOrder([FromBody] CreateSyncOrderIDQueueModel data)
        {
            SyncOrderIDQueueModel newSyncOrderIDQueue = new SyncOrderIDQueueModel();
            newSyncOrderIDQueue.create = DateTime.UtcNow;
            newSyncOrderIDQueue.action = ActionTypes.SYNC_ORDER.ToString().ToUpper();
            newSyncOrderIDQueue.companyID = data.companyID;
            newSyncOrderIDQueue.orderIDs = data.orderIDs;

            Dictionary<string, object> rs = new Dictionary<string, object>();
            try
            {
                logger.Info("Begin push {inQueueItems} to queue", data.orderIDs);
                if (newSyncOrderIDQueue.companyID > 0 && newSyncOrderIDQueue.orderIDs.Count > 0)
                {
                    Parallel.ForEach(_publishers, async publisher => { await publisher.SendMessage(newSyncOrderIDQueue); });

                    rs["c"] = ConstantCode.SUCCESSFULL;
                    rs["m"] = ConstantMessage.SUCCESSFULL;
                    rs["d"] = newSyncOrderIDQueue;
                }
                else
                {
                    rs["c"] = ConstantCode.PUSH_TO_QUEUE_FAIL;
                    rs["m"] = ConstantMessage.PUSH_TO_QUEUE_FAIL;
                }
            }
            catch (Exception e)
            {
                logger.Error(e, e.Message);
                Console.WriteLine(e.Message);

                rs["c"] = ConstantCode.EXCEPTION_ERROR;
                rs["m"] = ConstantMessage.EXCEPTION_ERROR + " : " + e.Message;
            }

            return rs;
        }
    }
}