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

namespace Adaconda.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string PASSWORD_SETUP = "";
        public string USER_SETUP = "";
        public ResultOfLogin resultOfLogin = ResultOfLogin.Fail;
        public Login()
        {
            InitializeComponent();
        }
        public bool RequestPassword(string userNameEnter, string userNameCorrect, string passwordEnter, string passwordCorrect)
        {
            if (passwordEnter == passwordCorrect && userNameEnter == userNameCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void login()
        {
            bool resultLogin = RequestPassword(tbx_UserName.Text, USER_SETUP, tbx_Password.Text, PASSWORD_SETUP);
            if (resultLogin)
            {

                resultOfLogin = ResultOfLogin.Pass;
                //Setup_Model setupModelWindow = new Setup_Model();
                //setupModelWindow.Show();
                this.Close();

            }
            else
            {
                resultOfLogin = ResultOfLogin.Fail;

                string messageBoxText = "Incorrect Password or User";
                string caption = "Login fail";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                if(result == MessageBoxResult.OK)
                {
                    tbx_UserName.Text = "";
                    tbx_Password.Text = "";

                }


            }
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            login();

        }

        private void tbx_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) login();

        }

        private void tbx_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) login();

        }
    }
    public enum ResultOfLogin
    {
        Pass,
        Fail
    }
}
