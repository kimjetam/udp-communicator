using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace UDP_communicator_2022
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

        private async void btn1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("PKS Client");
            PksClient pksClient = new PksClient("127.0.0.1", 8888);
            await pksClient.ConnectAsync();
        }

        private async void btn2_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("PKS Server");

            PksListener pksListener = new PksListener();
            await pksListener.ListenAsync(8888);
        }
    }
}
