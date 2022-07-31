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
using System.Windows.Shapes;
using Adaconda.Controller;
using System.ComponentModel;


namespace Adaconda.View
{
    /// <summary>
    /// Interaction logic for HardWareConfig.xaml
    /// </summary>
    public partial class HardWareConfig : Window, IUI, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }


        public MainWindow mainWindow = null;
        public MainWindow _mainWindow
        {
            get { return mainWindow; }
            set { mainWindow = value; }
        }

        public HardWareConfig(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.DataContext = this;
            this.OnPropertyChanged();
        }
        public void CallLoginForm()
        {

        }
        public void CallHardWareConfigForm()
        {

        }
        public void CloseForm(Window form)
        {
            form.Close();
        }
        public void CheckConnectStatus()
        {

        }
        private void exitHardWareConfig_Click(object sender, RoutedEventArgs e)
        {
            this.CloseForm(this);
        }
        
        

        private void btnCheckCntPLC1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
