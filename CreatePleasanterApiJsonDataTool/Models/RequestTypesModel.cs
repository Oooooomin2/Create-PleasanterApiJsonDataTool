using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePleasanterApiJsonDataTool.Models
{
    public sealed class RequestTypesModel
    {
        public RequestTypes RequestType { get; set; }
        public enum RequestTypes
        {
            Get,
            Create,
            Update,
            Delete
        }
    }
}
