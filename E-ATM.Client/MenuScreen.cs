using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E_ATM.Client
{
    public class MenuScreen
    {
        private MainWindow _mainWindow { get; set; }  

        public MenuScreen(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;    
        }

        public void DisplayMenu()
        {
        _mainWindow.lbl_M2.Content = "";
        _mainWindow.lbl_L1.Content = "WITHDRAW CASH";
        _mainWindow.lbl_L2.Content = "WITHDRAW CASH WITH RECIPT";
        _mainWindow.lbl_L3.Content = "DISPLAY BALANCE";
        _mainWindow.lbl_L4.Content = "MINI STATEMENT";

        _mainWindow.lbl_R1.Content = "ACCOUNT SERVICES";
        _mainWindow.lbl_R2.Content = "INFORMATION ON SERVICES";
        _mainWindow.lbl_R3.Content = "CHANGE PIN";
        _mainWindow.lbl_R4.Content = "OTHER"; 
        }
    
    }
}
