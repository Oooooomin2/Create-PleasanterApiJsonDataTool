using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePleasanterApiJsonDataTool.Models
{
    public sealed class CreateUpdateByApiModel : ItemHash
    {
        [JsonProperty(Order = 0)]
        public decimal ApiVersion { get; set; }
        [JsonProperty(Order = 1)]
        public string ApiKey { get; set; }
    }
}
