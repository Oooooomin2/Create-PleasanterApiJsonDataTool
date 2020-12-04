using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePleasanterApiJsonDataTool.Interfaces
{
    interface ICreateJson
    {
        string CreateJson(decimal apiVersion, string apiKey);
    }
}
