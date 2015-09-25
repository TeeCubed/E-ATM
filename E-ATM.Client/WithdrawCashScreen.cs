using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Client
{
    public class WithdrawCashScreen : Screen
    {
        public WithdrawCashScreen(MainWindow mainWindow) 
            : base(mainWindow)
        {
            Display();
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

        public override void Display()
        {
            _mainWindow.lbl_M1.Content = "Choose amount:";

            _mainWindow.lbl_L1.FontSize = 10;
            _mainWindow.lbl_L1.Content = "Menu";
            _mainWindow.lbl_L2.Content = "£10";
            _mainWindow.lbl_L3.Content = "£30";
            _mainWindow.lbl_L4.Content = "£100";

            _mainWindow.lbl_R1.Content = "";
            _mainWindow.lbl_R2.Content = "20£";
            _mainWindow.lbl_R3.Content = "50£";
            _mainWindow.lbl_R4.Content = "OTHER"; 
        }

        public override void Button_L1()
        {
            _mainWindow.CurrentScreen = new MenuScreen(_mainWindow);
        }
    }
}
