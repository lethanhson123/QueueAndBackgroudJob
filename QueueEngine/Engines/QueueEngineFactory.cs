using QueueEngine.Behaviors;
using QueueEngine.Engines.Amazon;
using QueueEngine.Engines.Google;
using QueueEngine.Models.QueueSetting;

namespace QueueEngine
{
    public class QueueEngineFactory
    {
        public static IQueuePublisher<T> CreatePublisher<T>(QueueProvider provider, QueueSetting queueSetting, string topicName)
        {
            IQueuePublisher<T> publisher = default;
            switch (provider)
            {
                case QueueProvider.GOOGLE:
                    publisher = new GoogleQueuePublisher<T>(queueSetting, topicName);
                    break;
                case QueueProvider.AWS:
                    publisher = new AmazonQueuePublisher<T>(queueSetting, topicName);
                    break;
            }
            return publisher;
        }

        public static IQueueSubscriber CreateSubscriber(QueueProvider provider, QueueSetting queueSetting, string subscriptionName, Action<object> handler)
        {
            IQueueSubscriber subscriber = default;
            switch (provider)
            {
                case QueueProvider.GOOGLE:
                    subscriber = new GoogleQueueSubscriber(queueSetting, subscriptionName, handler);
                    break;
                case QueueProvider.AWS:
                    subscriber = new AmazonQueueSubscriber(queueSetting, subscriptionName, handler);
                    break;
            }
            return subscriber;
        }
    }
}