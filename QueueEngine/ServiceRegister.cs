using BusinessServices.Models.MessageQueueModel;
using QueueEngine.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegister
    {
        public static void AddQueueService(this IServiceCollection services)
        {
            //services.AddSingleton<IQueueService<SendMailQueueModel>, QueueService<SendMailQueueModel>>();
            //services.AddSingleton<IQueueService<SyncImportOrganisationFullQueueModel>, QueueService<SyncImportOrganisationFullQueueModel>>();
        }
    }
}