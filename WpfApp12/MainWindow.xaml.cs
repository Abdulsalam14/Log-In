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

namespace WpfApp12
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


        public List<string> users { get; set; } = new List<string>() { "user+12345" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            for (int i = 0; i < users.Count; i++)
            {
                if ($"{txtbx1.Text}+{txtbx2.Text}" == users[i])
                {
                    MessageBox.Show("Correct", "LOG IN", MessageBoxButton.OK, MessageBoxImage.Information);
                    count++;
                    txtbx1.Text = "";
                    txtbx2.Text = "";
                }
                if (count == 0) MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
            App.Current.MainWindow.Close();
        }
    }
}
