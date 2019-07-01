using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace FirstHomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SearchIPorURL(object sender, RoutedEventArgs e)
        {

            var ipHostEntry = Dns.GetHostEntry(IPorURLTextBox.Text);
            IPAddressListBox.Items.Clear();
            foreach (var item in ipHostEntry.AddressList)
            {
                IPAddressListBox.Items.Add(item);
            }
            UrlTextBox.Text = ipHostEntry.HostName;
        }
    }
}
