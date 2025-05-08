using MSSQL_Lecture_WPF_Introduction.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MSSQL_Lecture_WPF_Introduction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        IViewModel viewModel;
        IViewModel ViewModel {  get { return viewModel; } set { viewModel = value; } }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel = new TextboxViewModel();
            DataContext = ViewModel;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewModel = new ComboboxViewModel();
            DataContext = ViewModel;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewModel = new DatepickerViewModel();
            DataContext = ViewModel;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewModel = new LabelViewModel();
            DataContext = ViewModel;
        }
    }
}