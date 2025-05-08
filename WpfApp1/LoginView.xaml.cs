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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;

            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");

            if(envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("Enter correct");
                }
                else
                {
                    MessageBox.Show("Enter Wrong");
                }
            }
            else
            {
                MessageBox.Show("not Found");
        }
    }
            }
}
