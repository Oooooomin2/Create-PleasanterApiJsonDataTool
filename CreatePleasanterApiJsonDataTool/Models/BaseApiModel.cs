using Newtonsoft.Json;

namespace CreatePleasanterApiJsonDataTool.Models
{
    public class BaseApiModel
    {
        [JsonProperty(Order = 0)]
        public decimal ApiVersion { get; set; }
        [JsonProperty(Order = 1)]
        public string ApiKey { get; set; }
    }
}
