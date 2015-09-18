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
using E_ATM.Library;

namespace E_ATM.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ATM Atm { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Atm = new ATM();
        }

        private void btn_InsertCard_Click(object sender, RoutedEventArgs e)
        {
            InsertCard insertCardWindow = new InsertCard(this);
            insertCardWindow.Show();


        }
    }
}
