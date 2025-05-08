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
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window
    {
        public List<Person> People { get; set; }

        public ListBox()
        {
            InitializeComponent();

            People = new List<Person>()
            {
                new Person("Jannick", 30),
                new Person("Marc", 20),
                new Person("Maria", 40),
                new Person("Lucas", 50)
            };

            ListBoxNames.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxNames.SelectedItems;

            foreach (Person item in selectedItems)
            {
                MessageBox.Show($"{item.GetType()} : {item.Name} : {item.Age}");
            }
        }
    }
}
