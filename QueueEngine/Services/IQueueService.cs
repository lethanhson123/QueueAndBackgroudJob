using System.Collections.Generic;

namespace QueueEngine.Services
{
    public interface IQueueService<T>
    {
        void PushQueue(T model);

        IList<T> ConsumeQueue(int lenght);
    }
}