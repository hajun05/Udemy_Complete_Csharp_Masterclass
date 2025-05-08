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
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Person person = new Person("Jannick", 30);

        public Window1()
        {
            InitializeComponent();

            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string PersonDate = person.Name + " is " + person.Age + " years old.";
            MessageBox.Show(PersonDate);
        }
    }
}
