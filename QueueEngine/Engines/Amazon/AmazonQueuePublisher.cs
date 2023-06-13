using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using QueueEngine.Behaviors;
using QueueEngine.Models.QueueSetting;
using System.Text.Json;

namespace QueueEngine.Engines.Amazon
{
    internal class AmazonQueuePublisher<T> : IQueuePublisher<T>
    {
        private AmazonSQSClient _publisher;
        private readonly AmazonQueueSetting _queueSetting;

        public AmazonQueuePublisher(QueueSetting queueSetting, string topicName)
        {
            _queueSetting = queueSetting as AmazonQueueSetting;
            InitializeQueue(topicName);
        }

        private void InitializeQueue(string topicName)
        {
            if (_publisher == null)
            {
                var credentials = new BasicAWSCredentials(_queueSetting.AccessKey, _queueSetting.SecretKey);
                var publisher = new AmazonSQSClient(credentials, RegionEndpoint.APSoutheast1);
                _publisher = publisher;
            }
        }

        public async Task SendMessage(T message)
        {
            var body = JsonSerializer.Serialize(message);

            var pubMessage = new SendMessageRequest()
            {
                QueueUrl = _queueSetting.QueueUrl,
                MessageBody = body
            };

            _ = await _publisher.SendMessageAsync(pubMessage);
        }

        public async Task SendMessages(IList<T> messages)
        {
            var publishTasks =
               messages.Select(async message =>
               {
                   await SendMessage(message);
               });
            await Task.WhenAll(publishTasks);
        }
    }
}