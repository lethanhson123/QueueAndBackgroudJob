namespace BusinessServices.Services.Interface
{
    public interface IAPIOrderDispatchsServices
    {
        Task<Dictionary<string, object>> CallAPIOrderDispatchs();
    }
}
