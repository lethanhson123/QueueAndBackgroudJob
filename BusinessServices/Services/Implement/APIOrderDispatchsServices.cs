using BusinessServices.Constants;
using BusinessServices.Services.Interface;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using System.Security.Authentication;
using Utilities;

namespace BusinessServices.Services.Implement
{
    public partial class APIOrderDispatchsServices : IAPIOrderDispatchsServices
    {
        private readonly ILogger<APIOrderDispatchsServices> _loggerWindows;
        public APIOrderDispatchsServices(
            ILogger<APIOrderDispatchsServices> loggerWindows)
        {
            _loggerWindows = loggerWindows;
        }

        public async Task<Dictionary<string, object>> CallAPIOrderDispatchs()
        {
            Dictionary<string, object> rs = new Dictionary<string, object>();

            var _host = $"{AppSettingsConstant.Application.ApiUrl}/Home/APIOrderDispatchs?secToken={AppSettingsConstant.Application.ApiSecToken}";

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };
            clientHandler.SslProtocols = SslProtocols.Tls;

            var client = new HttpClient(clientHandler);
            var response = client.GetAsync(_host).Result;
            _loggerWindows.LogInformation(JsonConvert.SerializeObject(response));
            if (response.StatusCode != HttpStatusCode.OK)
            {
                rs["c"] = ConstantCode.CALL_API_ORDER_DISPATCH_FAIL;
                rs["m"] = response.Content;
                rs["d"] = JsonConvert.SerializeObject(response);
            }
            else
            {
                rs["c"] = ConstantCode.SUCCESSFULL;
                rs["m"] = response.StatusCode;
                rs["d"] = JsonConvert.SerializeObject(response);
            }

            return rs;
        }
    }
}
