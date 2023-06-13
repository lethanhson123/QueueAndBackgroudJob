using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using QueueEngine.Behaviors;
using QueueEngine.Models.QueueSetting;

namespace QueueEngine.Engines.Amazon
{
    internal class AmazonQueueSubscriber : IQueueSubscriber
    {
        private AmazonSQSClient _subscriber;
        private readonly AmazonQueueSetting _queueSetting;
        private readonly Action<Message> _messageHandler;

        public AmazonQueueSubscriber(QueueSetting queueSetting, string subscriptionName, Action<Message> messageHandler)
        {
            _queueSetting = queueSetting as AmazonQueueSetting;
            _messageHandler = messageHandler;
            InitializeQueue(subscriptionName);
        }

        private void InitializeQueue(string subscriptionName)
        {
            if (_subscriber == null)
            {
                var credentials = new BasicAWSCredentials(_queueSetting.AccessKey, _queueSetting.SecretKey);
                var subscriber = new AmazonSQSClient(credentials, RegionEndpoint.APSoutheast1);
                _subscriber = subscriber;
            }
        }

        /// <summary>
        /// Process subscriber message queue
        /// </summary>
        /// <returns></returns>
        public async Task ProcessQueue()
        {
            var request = new ReceiveMessageRequest()
            {
                QueueUrl = _queueSetting.QueueUrl,
            };

            var response = await _subscriber.ReceiveMessageAsync(request);
            response.Messages.ForEach(message =>
            {
                string body = message.Body;
                _messageHandler(message);
            });
        }

        /// <summary>
        /// Process delete message queue
        /// </summary>
        /// <returns></returns>
        public async Task DeleteMessage(string actionDelete, string receiptHandle)
        {
            Console.WriteLine($"\nDeleting message from queue...");
            var result = _subscriber.DeleteMessageAsync(_queueSetting.QueueUrl, receiptHandle).Result;
        }
    }
}