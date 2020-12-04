using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePleasanterApiJsonDataTool.Models
{
    public class ItemHash
    {
        [JsonProperty(Order = 3)]
        public object ClassHash { get; set; } = new { };
        [JsonProperty(Order = 3)]
        public object NumHash { get; set; } = new { };
        [JsonProperty(Order = 3)]
        public object DateHash { get; set; } = new { };
        [JsonProperty(Order = 3)]
        public object DescriptionHash { get; set; } = new { };
        [JsonProperty(Order = 3)]
        public object CheckHash { get; set; } = new { };
    }
}
