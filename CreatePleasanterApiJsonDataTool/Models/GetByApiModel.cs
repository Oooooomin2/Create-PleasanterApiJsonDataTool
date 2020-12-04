using Newtonsoft.Json;

namespace CreatePleasanterApiJsonDataTool.Models
{  
    public class GetByApiModel : BaseApiModel
    {
        [JsonProperty(Order = 2)]
        public object View { get; set; } = new { };
    }
}
