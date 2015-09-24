using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        private MenuScreen display;

        public MainWindow()
        {
            InitializeComponent();

            Atm = new ATM();
            display = new MenuScreen(this);
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
            Atm.UserInput = 1;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "1";
                    }
                    break;
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 2;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "2";
                    }
                    else
                    {
                        MessageBox.Show(Atm.UserString);
                    }
                    break;
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 3;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "3";
                    }
                    break;
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 4;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "4";
                    }
                    break;
            }
        }
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 5;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "5";
                    }
                    break;
            }
        }
        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 6;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "6";
                    }
                    break;
            }
        }
        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 7;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "7";
                    }
                    break;
            }
        }
        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 8;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "8";
                    }
                    break;
            }
        }
        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 9;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "9";
                    }
                    break;
            }
        }
        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserInput = 0;

            switch (Atm.State)
            {
                case ATMState.Pin:
                    if (lbl_M2.Content.ToString().Length < 4)
                    {
                        lbl_M2.Content += "*";
                        Atm.UserString += "0";
                    }
                    break;
            }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            Atm.UserString = Atm.UserString.Remove(Atm.UserString.Length - 1, 1);
            lbl_M2.Content = lbl_M2.Content.ToString().Remove(lbl_M2.Content.ToString().Length - 1, 1);
        }

        private void btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            lbl_M1.Content = "";
            lbl_M2.FontSize = 16;
            double thickness = lbl_M2.BorderThickness.Bottom - 3;
            lbl_M2.BorderThickness = new Thickness(thickness);

            if (Atm.UserString == "1234")
            {
                lbl_M2.Content = "Login Successful!";

                Dispatcher.Invoke(new Action(() => { }), DispatcherPriority.ContextIdle, null);

                Thread.Sleep(3000);

                display.DisplayMenu();

            }
            else
            {
                lbl_M2.Content = "Invalid Login.";
            }

            Dispatcher.Invoke(new Action(() => { }), DispatcherPriority.ContextIdle, null);

            Thread.Sleep(1500);

            lbl_M2.Content = "";
        }
    }
}
