using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using E_ATM.Library;

namespace E_ATM.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ATM Atm { get; set; }
        public Screen CurrentScreen { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Atm = new ATM();

            CurrentScreen = new PinScreen(this);
        }

        private void btn_InsertCard_Click(object sender, RoutedEventArgs e)
        {
            lbl_M4.Content = "";
            lbl_M2.Content = "Processing...";

            InsertCard insertCardWindow = new InsertCard(this);
            insertCardWindow.Show();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad1();
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad2();
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad3();
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad4();
        }
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad5();
        }
        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad6();
        }
        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad7();
        }
        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad8();
        }
        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad9();
        }
        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_Keypad0();
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_KeypadClear();
        }

        private void btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_KeypadEnter();
        }

        private void btn_L1_Click(object sender, RoutedEventArgs e)
        {
            CurrentScreen.Button_L1();
        }

    }
}
