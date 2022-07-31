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
using Adaconda.Model;
using System.ComponentModel;
using System.IO;
using Point = Adaconda.Model.Point;
using System.Data;
using Microsoft.Win32;
using Adaconda.Utils;

namespace Adaconda.View
{
    /// <summary>
    /// Interaction logic for Model_Management.xaml
    /// </summary>
    public partial class Model_Management : Window, IUI, INotifyPropertyChanged
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

        public MainWindow mainWindow;

        public Model.Model model { get; set; }
        
        //Init
        public Model_Management(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.DataContext = this;
            



        }
        //Method
        public MainWindow bmainWindow
        {
            get { return mainWindow; }
            set { mainWindow = value; this.Refresh(); }
        }

        public void CallHardWareConfigForm()
        {
            var hardWareConfigForm = new HardWareConfig(this.mainWindow);
            hardWareConfigForm.ShowDialog();
        }
        public void CallLoginForm()
        {

        }
        public void CloseForm(Window form)
        {

        }

        private void HardwareConfig_Click(object sender, RoutedEventArgs e)
        {
            this.CallHardWareConfigForm();
        }
        private void AddNewModel()
        {
            var newModel = new New.AddNewModel(this.mainWindow);
            newModel.ShowDialog();
            CollectionViewSource.GetDefaultView(cbb_SelectModel.ItemsSource).Refresh();


        }

        //private void Refresh()
        //{
        //    this.cbbTargetPoint.ItemsSource = new List<object>();
        //    this.cbbTargetPoint.ItemsSource = model.listPoint;
        //    this.cbbTargetPoint.DisplayMemberPath = "name";
        //}






        //Event
        private void btnSaveModel_Click(object sender, RoutedEventArgs e)
        {
            if(model != null)
            {
                this.Refresh();
                model.Save();
            }
            
        }
        private void btnAddModel_Click(object sender, RoutedEventArgs e)
        {
            
            this.AddNewModel();
            //this.cbb_SelectModel.ItemsSource = new List<string>();
            //this.cbb_SelectModel.ItemsSource = mainWindow._ListModelName;

        }

        private void btnDelModel_Click(object sender, RoutedEventArgs e)
        {
            //Directory.Delete()
            this.Refresh();
        }

        private void cbb_SelectModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                if(this.cbb_SelectModel.SelectedIndex != -1)
                {
                    var name = cbb_SelectModel.SelectedValue.ToString();

                    if (!mainWindow._ListModelAvailable.Contains(name))
                    {
                        model = new Model.Model(name);
                    }
                    else
                    {
                        model = Model.Model.LoadModel(name);
                        this.Refresh();
                        CollectionViewSource.GetDefaultView(dgvCoordinate.ItemsSource).Refresh();

                        //this.Refresh();
                        //this.OnPropertyChanged();


                    }
                }

            });
            
        }

        private void cbbTargetPoint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbbTargetPoint.SelectedIndex != -1)
            {
                model.targetPoint = model.listPoint[cbbTargetPoint.SelectedIndex].coordinate;
                this.Refresh();
            }
        }
        private void btnAddPoint_Click(object sender, RoutedEventArgs e)
        {
            this.dgvCoordinate.CanUserAddRows = true;
            this.model.listPoint.Add(new Point());
            this.Refresh();
            this.dgvCoordinate.CanUserAddRows = false;

        }

        private void btnDelPoint_Click(object sender, RoutedEventArgs e)
        {
            var items = dgvCoordinate.SelectedItems;
            foreach (Point item in items)
            {
                if (model.listPoint.Contains(item))
                {
                    model.listPoint.Remove(item);
                }
            }
            this.Refresh();
            CollectionViewSource.GetDefaultView(dgvCoordinate.ItemsSource).Refresh();



        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            this.Refresh();

        }

        private void btnInsertPoint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.S && Keyboard.Modifiers == ModifierKeys.Control)
            {
                this.btnSaveModel_Click(null, null);
            }
            
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {

        }

        private void btnImportPLCCode_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(Config.Config.PLCCodePath))
            {
                Directory.CreateDirectory(Config.Config.PLCCodePath);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            GcodeCompiler gcodeCompiler = new GcodeCompiler();

            if (openFileDialog.ShowDialog() == true)
            {
                var pathText = openFileDialog.FileName;
                var resultComplie = gcodeCompiler.ConvertTxtToPLC(pathText);
                string error = "Not complie in lines : ";
                foreach(string s in resultComplie.listErrorCpl)
                {
                    error += string.Format("{0};", s);
                }
                if (resultComplie.listErrorCpl.Count > 0)
                MessageBox.Show(error, "Error Complie");

            }
        }
    }
}
