using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace E_ATM.Client
{
    class PinScreen : Screen
    {
        public PinScreen(MainWindow mainWindow) 
            : base(mainWindow)
        {
            
        }

        public override void Button_Keypad1()
        {
            _mainWindow.Atm.UserInput = 1;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "1";
            }
        }

        public override void Button_Keypad2()
        {
            _mainWindow.Atm.UserInput = 2;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "2";
            }
        }

        public override void Button_Keypad3()
        {
            _mainWindow.Atm.UserInput = 3;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "3";
            }
        }

        public override void Button_Keypad4()
        {
            _mainWindow.Atm.UserInput = 4;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "4";
            }
        }

        public override void Button_Keypad5()
        {
            _mainWindow.Atm.UserInput = 5;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "5";
            }
        }

        public override void Button_Keypad6()
        {
            _mainWindow.Atm.UserInput = 6;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "6";
            }
        }

        public override void Button_Keypad7()
        {
            _mainWindow.Atm.UserInput = 7;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "7";
            }
        }

        public override void Button_Keypad8()
        {
            _mainWindow.Atm.UserInput = 8;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "8";
            }
        }

        public override void Button_Keypad9()
        {
            _mainWindow.Atm.UserInput = 9;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "9";
            }
        }

        public override void Button_Keypad0()
        {
            _mainWindow.Atm.UserInput = 0;

            if (_mainWindow.lbl_M2.Content.ToString().Length < 4)
            {
                _mainWindow.lbl_M2.Content += "*";
                _mainWindow.Atm.UserString += "0";
            }
        }

        public override void Button_KeypadEnter()
        {
            _mainWindow.lbl_M1.Content = "";
            _mainWindow.lbl_M2.FontSize = 16;
            double thickness = _mainWindow.lbl_M2.BorderThickness.Bottom - 3;
            _mainWindow.lbl_M2.BorderThickness = new Thickness(thickness);

            if (_mainWindow.Atm.UserString == "1234")
            {
                _mainWindow.lbl_M2.Content = "Login Successful!";
                _mainWindow.Dispatcher.Invoke(new Action(() => { }), DispatcherPriority.ContextIdle, null);
                Thread.Sleep(3000);
                _mainWindow.CurrentScreen = new MenuScreen(_mainWindow);
                //display.DisplayMenu();
            }
            else
            {
                _mainWindow.lbl_M2.Content = "Invalid Login.";
                _mainWindow.Dispatcher.Invoke(new Action(() => { }), DispatcherPriority.ContextIdle, null);          
                Thread.Sleep(1500);
            }
        }

        public override void Button_KeypadCancel()
        {
            throw new NotImplementedException();
        }

        public override void Button_KeypadClear()
        {
            _mainWindow.Atm.UserString = _mainWindow.Atm.UserString.Remove(_mainWindow.Atm.UserString.Length - 1, 1);
            _mainWindow.lbl_M2.Content = _mainWindow.lbl_M2.Content.ToString().Remove(_mainWindow.lbl_M2.Content.ToString().Length - 1, 1);
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Button_L1()
        {
            throw new NotImplementedException();
        }
    }
}
