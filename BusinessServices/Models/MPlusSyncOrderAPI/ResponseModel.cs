using Newtonsoft.Json;

namespace BusinessServices.Models.MPlusSyncOrderAPI
{
    public class BasicResponse
    {
        [JsonProperty("Status")]
        public bool Status { get; set; }
        [JsonProperty("Message")]
        public string Message { get; set; }
    }

    public class ResponseModel : BasicResponse
    {
        public ResponseModel()
        {
            Data = new List<ResponseDetailData>();
        }
        [JsonProperty("Data")]
        public List<ResponseDetailData> Data { get; set; }
    }

    public class ResponseDetailData
    {
        [JsonProperty("OrderID")]
        public int OrderNo { get; set; }
        [JsonProperty("TPF_UniqueRefID")]
        public int ReferenceId { get; set; }

        [JsonProperty("UploadID")]
        public int UploadID { get; set; }

        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class ResponseLogin : BasicResponse
    {
        public ResponseLogin()
        {
            Data = new ResponseLoginData();
        }
        [JsonProperty("Data")]
        public ResponseLoginData Data { get; set; }
    }

    public class ResponseLoginData
    {
        [JsonProperty("Token")]
        public string Token { get; set; }
        [JsonProperty("Expiration")]
        public DateTime Expiration { get; set; }
    }
}
