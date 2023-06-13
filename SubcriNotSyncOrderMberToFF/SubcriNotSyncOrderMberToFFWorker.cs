using Amazon.SQS.Model;
using BusinessServices.Constants;
using BusinessServices.Models.MessageQueueModel;
using BusinessServices.Services.Interface;
using Newtonsoft.Json;
using QueueEngine;
using QueueEngine.Behaviors;
using QueueEngine.Models.QueueSetting;
using Utilities;

namespace SubcriNotSyncOrderMberToFF
{
    public class SubcriNotSyncOrderMberToFFWorker : BackgroundService
    {
        private readonly ILogger<SubcriNotSyncOrderMberToFFWorker> _loggerWindows;
        private readonly IQueueSubscriber _subscriber;
        private readonly IMplusOrderNotSyncYetServices _service;

        public SubcriNotSyncOrderMberToFFWorker(
            ILogger<SubcriNotSyncOrderMberToFFWorker> loggerWindows,
            IMplusOrderNotSyncYetServices service)
        {
            _service = service;
            _subscriber = CreateSubscriber();
            _loggerWindows = loggerWindows;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_subscriber != null)
                {
                    await _subscriber.ProcessQueue();
                }
            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _loggerWindows.LogWarning(this.GetType().Name + " STARTING: {time}", DateTimeOffset.Now);
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _loggerWindows.LogWarning(this.GetType().Name + " STOPPING: {time}", DateTimeOffset.Now);
            return base.StopAsync(cancellationToken);
        }

        private IQueueSubscriber CreateSubscriber()
        {
            try
            {
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

                        return QueueEngineFactory.CreateSubscriber(provider, amazonSetting, "", MesageHandler);
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, ex.Message);
            }

            return default;
        }

        private void MesageHandler(object messageQueue)
        {
            try
            {
                Message _message = (Message)messageQueue;
                var data = JsonConvert.DeserializeObject<SyncOrderMplusToFFQueueModel>(_message.Body);
                if (data.action.ToUpper().Equals(ActionTypes.SYNC_ORDER.ToString().ToUpper()) && data.status.ToUpper().Equals(ActionStatus.NEW.ToString().ToUpper()))
                {
                    _loggerWindows.LogWarning("Begin {syncOrder}.", $"sync order: companyID={data.item.CompanyID}, WebOrderId={data.item.WebOrderId}");
                    //Task<Dictionary<string, object>> result = _service.subcriberSyncOrder(data);
                    Dictionary<string, object> result = _service.subcriberSyncOrder(data);

                    if (result["c"].Equals(ConstantCode.SUCCESSFULL))
                    {
                        _subscriber.DeleteMessage(data.action, _message.ReceiptHandle);
                        _loggerWindows.LogWarning("{DeleteMessage} successful!!!", $"Delete from AWS SQS: SQS MessageId={_message.MessageId}, Action={data.action}");
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
        }
    }
}