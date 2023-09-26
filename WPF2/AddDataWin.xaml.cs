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
using WPF2.ViewModels;

namespace WPF2
{
    /// <summary>
    /// Interaction logic for AddDataWin.xaml
    /// </summary>

    public partial class AddDataWin : Window
    {
        public AddDataWin(AddStudentVM addS)
    {
        InitializeComponent();
        DataContext = addS;
        addS.CloseAction = () => Close();
    }

    private void BtnClose_Click(object sender, RoutedEventArgs e)
    {
            var mW = new MainWindow();
            mW.Show();
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            this.DragMove();
        }
    }

}
}
