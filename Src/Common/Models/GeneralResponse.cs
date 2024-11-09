using Newtonsoft.Json;

namespace bybit.net.api.Models
{
    public class GeneralResponse
    {
        [JsonProperty("retCode")]
        public int? RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string? RetMsg { get; set; }

        [JsonProperty("retExtInfo")]
        public Dictionary<string, object>? RetExtInfo { get; set; }

        [JsonProperty("time")]
        public long? Time { get; set; }
    }
    
    public class GeneralResponse<T> : GeneralResponse
    {
        [JsonProperty("result")]
        public T? Result { get; set; }
    }
}
