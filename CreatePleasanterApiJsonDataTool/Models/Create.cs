using CreatePleasanterApiJsonDataTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using static CreatePleasanterApiJsonDataTool.Models.RequestTypesModel;

namespace CreatePleasanterApiJsonDataTool.Models
{
    public sealed class Create : ICreateJson
    {
        public BaseApiModel BaseApiModel { get; set; }
        public GetByApiModel GetByApiModel { get; set; }
        public CreateUpdateByApiModel CreateUpdateByApiModel { get; set; }
        public RequestTypes RequestTypes { get; set; }

        public Create(RequestTypes requestTypes)
        {
            RequestTypes = requestTypes;
        }

        public string CreateJson(decimal apiVersion, string apiKey)
        {
            switch (apiVersion)
            {
                case 1.000M:
                    switch (RequestTypes)
                    {
                        case RequestTypes.Get:
                            GetByApiModel = new GetByApiModel
                            {
                                ApiVersion = apiVersion,
                                ApiKey = apiKey,
                                View = new ViewModel()
                            };
                            return JsonConvert.SerializeObject(GetByApiModel, Formatting.Indented);
                        case RequestTypes.Create:
                        case RequestTypes.Update:
                        case RequestTypes.Delete:
                        default:
                            CreateBaseApiModel(apiVersion, apiKey);
                            return JsonConvert.SerializeObject(BaseApiModel, Formatting.Indented);
                    }
                case 1.100M:
                default:
                    switch (RequestTypes)
                    {
                        case RequestTypes.Get:
                            GetByApiModel = new GetByApiModel
                            {
                                ApiVersion = apiVersion,
                                ApiKey = apiKey,
                                View = new ViewModel()
                                {
                                    ColumnFilterHash = new ItemHash(),
                                    ColumnSorterHash = new ItemHash()
                                }
                            };
                            return JsonConvert.SerializeObject(GetByApiModel, Formatting.Indented);
                        case RequestTypes.Create:
                        case RequestTypes.Update:
                            CreateUpdateByApiModel = new CreateUpdateByApiModel
                            {
                                ApiVersion = apiVersion,
                                ApiKey = apiKey
                            };
                            return JsonConvert.SerializeObject(CreateUpdateByApiModel, Formatting.Indented);
                        case RequestTypes.Delete:
                        default:
                            CreateBaseApiModel(apiVersion, apiKey);
                            return JsonConvert.SerializeObject(BaseApiModel, Formatting.Indented);
                    }
            }
            
        }

        private void CreateBaseApiModel(decimal apiVersion, string apiKey)
        {
            BaseApiModel = new BaseApiModel
            {
                ApiVersion = apiVersion,
                ApiKey = apiKey
            };
        }
    }
}
