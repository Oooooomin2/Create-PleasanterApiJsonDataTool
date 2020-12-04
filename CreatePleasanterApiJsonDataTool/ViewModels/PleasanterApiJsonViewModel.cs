using CreatePleasanterApiJsonDataTool.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using static CreatePleasanterApiJsonDataTool.Models.RequestTypesModel;

namespace CreatePleasanterApiJsonDataTool.ViewModels
{
    internal sealed class PleasanterApiJsonViewModel : BindableBase
    {
        private ObservableCollection<decimal> apiVersion = new ObservableCollection<decimal>
        {
            1.1M,
            1.0M
        };
        internal ObservableCollection<decimal> ApiVersion
        {
            get
            {
                return apiVersion;
            }
            set
            {
                SetProperty(ref apiVersion, value);
            }
        }

        private decimal selectedApiVersion;
        internal decimal SelectedApiVersion
        {
            get
            {
                return selectedApiVersion;
            }
            set
            {
                SetProperty(ref selectedApiVersion, value);
            }
        }

        private string apiKey;
        internal string ApiKey
        {
            get
            {
                return apiKey;
            }
            set
            {
                SetProperty(ref apiKey, value);
            }
        }

        private Dictionary<RequestTypes, string> requestType = new Dictionary<RequestTypes, string>()
        {
            { RequestTypes.Get, "取得" },
            { RequestTypes.Create, "作成" },
            { RequestTypes.Update, "更新" },
            { RequestTypes.Delete, "削除" },
        };
        internal Dictionary<RequestTypes, string> RequestType
        {
            get
            {
                return requestType;
            }
            set
            {
                SetProperty(ref requestType, value);
            }
        }

        private RequestTypes selectedRequestType;
        internal RequestTypes SelectedRequestType
        {
            get
            {
                return selectedRequestType;
            }
            set
            {
                SetProperty(ref selectedRequestType, value);
            }
        }

        private string resultJsonData;
        internal string ResultJsonData
        {
            get
            {
                return resultJsonData;
            }
            set
            {
                SetProperty(ref resultJsonData, value);
            }
        }

        internal PleasanterApiJsonViewModel()
        {
        }

        internal string CreateJsonString()
        {
            return new Create(selectedRequestType).CreateJson(SelectedApiVersion, ApiKey);
        }
    }
}
