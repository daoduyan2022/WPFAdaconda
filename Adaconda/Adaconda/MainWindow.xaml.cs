using System;
using System.Collections.Generic;
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
using Adaconda.View;
using Adaconda.Controller;
using System.ComponentModel;

namespace Adaconda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IUI, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void Refresh()
        {
            this.OnPropertyChanged();
        }

        Controller.MainController _MainController = null;
        public List<string> _ListModelName { get; set; } = new List<string>();
        public List<string> _ListModelAvailable { get; set; } = new List<string>();

        public ConnectionStatus _IsConnectionPLC1 { get; set; }
        public ConnectionStatus _IsConnectionPLC2 { get; set; }
        public ConnectionStatus _IsConnectionPLC3 { get; set; }
        public ConnectionStatus _IsConnectionPLC4 { get; set; }

        public SolidColorBrush _StatusConnectPLC1 { get; set; }
        public SolidColorBrush _StatusConnectPLC2 { get; set; }
        public SolidColorBrush _StatusConnectPLC3 { get; set; }
        public SolidColorBrush _StatusConnectPLC4 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _MainController = new Controller.MainController(this);
            this.LoadUIData();

            this.DataContext = this;
            this.Refresh();
        }
        public void LoadUIData()
        {
            _MainController.GetListModelName();

            this._IsConnectionPLC1 = ConnectionStatus.Fail;
            this._IsConnectionPLC2 = ConnectionStatus.Fail;
            this._IsConnectionPLC3 = ConnectionStatus.Fail;
            this._IsConnectionPLC4 = ConnectionStatus.Fail;

            this._StatusConnectPLC1 = Brushes.Red;
            this._StatusConnectPLC2 = Brushes.Red;
            this._StatusConnectPLC3 = Brushes.Red;
            this._StatusConnectPLC4 = Brushes.Red;
            //this.cbb_SelectModel.ItemsSource = new List<string>();
            //this.cbb_SelectModel.ItemsSource = this._ListModelName;
        }

        public void CallLoginForm()
        {
            var login = new Login();
            login.ShowDialog();
            if (login.resultOfLogin == ResultOfLogin.Pass)
            {
                var modelManager = new Model_Management(this);
                modelManager.ShowDialog();
            }
        }
        public void CallHardWareConfigForm()
        {
            var hardWareConfigForm = new HardWareConfig(this);
            hardWareConfigForm.ShowDialog();
        }
        public void CloseForm(Window form)
        {
            this.Close();
        }


        private void btnModelManagement_Click(object sender, RoutedEventArgs e)
        {
            CallLoginForm();
        }

        private void SetupModel_Click(object sender, RoutedEventArgs e)
        {
            CallLoginForm();

        }

        private void HardwareConfig_Click(object sender, RoutedEventArgs e)
        {
            this.CallHardWareConfigForm();
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.CloseForm(this);
        }

        private void cbb_SelectModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
    public enum ConnectionStatus
    {
        Fail,
        Success,
    }
}
