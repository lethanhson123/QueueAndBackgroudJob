namespace SubcribeOrderDeliveryNotSync
{
	public class SubcribeOrderDeliveryNotSyncWorker : BackgroundService
	{
		private readonly ILogger<SubcribeOrderDeliveryNotSyncWorker> _loggerWindows;
		private readonly IQueueSubscriber _subscriber;
		private readonly IMemberPlusOrderDeliveryNotSyncServices _memberPlusOrderDeliveryServices;

		public SubcribeOrderDeliveryNotSyncWorker(ILogger<SubcribeOrderDeliveryNotSyncWorker> loggerWindows
			, IMemberPlusOrderDeliveryNotSyncServices memberPlusOrderDeliveryServices
			)
		{
			_loggerWindows = loggerWindows;
			_subscriber = CreateSubscriber();
			_memberPlusOrderDeliveryServices = memberPlusOrderDeliveryServices;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			try
			{

				while (!stoppingToken.IsCancellationRequested)
				{
					if (_subscriber != null)
					{
						await _subscriber.ProcessQueue();
					}
				}
			}
			catch (Exception ex)
			{
				_loggerWindows.LogError(ex, ex.Message);
				Environment.Exit(1);
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
				var data = JsonConvert.DeserializeObject<MemberPlusOrderDeliveryNotSyncQueueModel>(_message.Body);

				if (data.action.ToUpper().Equals(ActionTypes.SYNC_ORDER_DELIVERY_NOTSYNC.ToString().ToUpper()) && data.status.ToUpper().Equals(ActionStatus.NEW.ToString().ToUpper()))
				{
					if (data.item.OrderId > 0)
					{
						_loggerWindows.LogWarning("Begin {WarningMessage}.", $"sync OrderDeliveryNotSync: CompanyID={data.item.CompanyID}, OrderId={data.item.OrderId}");
						Task<Dictionary<string, object>> result = _memberPlusOrderDeliveryServices.SubcriberAsync(data);
						if (result.Result["c"].Equals(ConstantCode.SUCCESSFULL))
						{
							_subscriber.DeleteMessage(data.action, _message.ReceiptHandle);
							_loggerWindows.LogWarning("{DeleteMessage} successful!!!", $"Delete from AWS SQS: SQS MessageId={_message.MessageId}, Action={data.action}");
						}
					}
					else
					{
						_subscriber.DeleteMessage(data.action, _message.ReceiptHandle);
						_loggerWindows.LogWarning("{DeleteMessage} successful!!!", $"Delete from AWS SQS: SQS MessageId={_message.MessageId}, Action={data.action}");
					}
				}
			}
			catch (Exception ex)
			{
				_loggerWindows.LogError(ex, ex.Message);
			}
		}
	}
}