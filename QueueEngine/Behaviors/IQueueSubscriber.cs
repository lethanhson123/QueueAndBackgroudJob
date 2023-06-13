using System.Threading.Tasks;

namespace QueueEngine.Behaviors
{
    public interface IQueueSubscriber
    {
        Task ProcessQueue();
        Task DeleteMessage(string body, string receiptHandle);
    }
}