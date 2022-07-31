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

namespace Adaconda.View.New
{
    /// <summary>
    /// Interaction logic for AddNewModel.xaml
    /// </summary>
    public partial class AddNewModel : Window
    {
        public MainWindow mainWindow = null;
        public AddNewModel(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void addNewModel_Click(object sender, RoutedEventArgs e)
        {
            if (!mainWindow._ListModelName.Contains(tbxNewModelName.Text))
            {
                mainWindow._ListModelName.Add(tbxNewModelName.Text);
               

            }
            else
            {
                MessageBox.Show("Model already exists. Please enter another name", "User Error");
            }
        }
    }
}
