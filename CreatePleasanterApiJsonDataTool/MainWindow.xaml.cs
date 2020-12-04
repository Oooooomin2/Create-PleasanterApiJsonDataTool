using CreatePleasanterApiJsonDataTool.Models;
using CreatePleasanterApiJsonDataTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static CreatePleasanterApiJsonDataTool.Models.RequestTypesModel;

namespace CreatePleasanterApiJsonDataTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var pleasanterApiJsonViewModel = new PleasanterApiJsonViewModel();
            ApiVersionComboBox.ItemsSource = pleasanterApiJsonViewModel.ApiVersion;
            ApiVersionComboBox.SelectedValue = pleasanterApiJsonViewModel.ApiVersion[0];
            RequestTypeComboBox.ItemsSource = pleasanterApiJsonViewModel.RequestType;
            RequestTypeComboBox.SelectedValue = pleasanterApiJsonViewModel.RequestType.FirstOrDefault().Key;
        }

        private void JsonCreateButtom_Click(object sender, RoutedEventArgs e)
        {
            var pleasanterApiJsonViewModel = new PleasanterApiJsonViewModel();
            pleasanterApiJsonViewModel.SelectedRequestType = (RequestTypes)RequestTypeComboBox.SelectedValue;
            pleasanterApiJsonViewModel.SelectedApiVersion = (decimal)ApiVersionComboBox.SelectedValue;
            pleasanterApiJsonViewModel.ApiKey = ApiKeyTextBox.Text;
            JsonResultText.Text = pleasanterApiJsonViewModel.CreateJsonString();
        }
    }
}
