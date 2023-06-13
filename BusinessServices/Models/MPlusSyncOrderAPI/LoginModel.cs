using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace BusinessServices.Models.MPlusSyncOrderAPI
{
    public class LoginModel
    {
        public LoginModel(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }


        public ResponseLogin Login(string url)
        {
            var result = new ResponseLogin();
            result.Status = false;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls |
                //                                       SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Ssl3;


                var typeContent = "application/json";
                var client = new RestClient(url);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.Timeout = 60000;
                request.AddHeader("Content-Type", typeContent);
                var modelLogin = new LoginModel(Username, Password);
                var body = JsonConvert.SerializeObject(modelLogin);
                request.AddParameter(typeContent, body, ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    result.Status = false;
                    result.Message = result.Message;
                    result.Data = null;
                    return result;
                }
                var resultRespon = JsonConvert.DeserializeObject<ResponseLogin>(response.Content);
                if (resultRespon != null)
                {
                    result = resultRespon;
                }
                else
                {
                    result.Status = false;
                    result.Message = $"Sync login API fail! ({response?.Content})";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
            }
            return result;
        }



    }
}