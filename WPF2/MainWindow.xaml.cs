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
using WPF2.ViewModels;

namespace WPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
            //LoadData();
        }

        public void LoadData()
        {
            //DGridCustomer.ItemsSource = _db.CustomerDBs.ToList();
            //datagrid = DGridCustomer;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var result = _db.CustomerDBs.Where(x => x.Name.Contains(TBoxSearch.Text) || x.Address.Contains(TBoxSearch.Text) || x.Phone.Contains(TBoxSearch.Text)).ToList();
            //DGridCustomer.ItemsSource = result;
        }
    }
}
