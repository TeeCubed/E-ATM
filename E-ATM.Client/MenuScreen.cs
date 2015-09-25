﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using E_ATM.Library;

namespace E_ATM.Client
{
    public class MenuScreen : Screen
    {
        public MenuScreen(MainWindow mainWindow) : base(mainWindow)
        {
            _mainWindow.lbl_M2.Content = "";
            Display();
        }
        
        public override void Display()
        {
            _mainWindow.lbl_L1.FontSize = 12;
            _mainWindow.lbl_L1.Content = "WITHDRAW CASH";
            _mainWindow.lbl_L2.Content = "WITHDRAW CASH WITH RECEIPT";
            _mainWindow.lbl_L3.Content = "DISPLAY BALANCE";
            _mainWindow.lbl_L4.Content = "MINI STATEMENT";

            _mainWindow.lbl_M1.Content = "";
            _mainWindow.lbl_M2.Content = "";

            _mainWindow.lbl_R1.Content = "ACCOUNT SERVICES";
            _mainWindow.lbl_R2.Content = "INFORMATION ON SERVICES";
            _mainWindow.lbl_R3.Content = "CHANGE PIN";
            _mainWindow.lbl_R4.Content = "OTHER";
        }

        public override void Button_Keypad1()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad2()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad3()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad4()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad5()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad6()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad7()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad8()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad9()
        {
            throw new NotImplementedException();
        }

        public override void Button_Keypad0()
        {
            throw new NotImplementedException();
        }

        public override void Button_KeypadEnter()
        {
            throw new NotImplementedException();
        }

        public override void Button_KeypadCancel()
        {
            throw new NotImplementedException();
        }

        public override void Button_KeypadClear()
        {
            throw new NotImplementedException();
        }

        public override void Button_L1()
        {
            _mainWindow.CurrentScreen = new WithdrawCashScreen(_mainWindow);
        }
    }
}
