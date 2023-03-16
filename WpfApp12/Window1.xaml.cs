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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtbx1.Text.Length > 0 && txtbx2.Text.Length > 0 && txtbx3.Text.Length > 0 && txtbx4.Text.Length > 0)
            {
                MessageBox.Show("Created.", "Register", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else MessageBox.Show("Invalid", "Register", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
