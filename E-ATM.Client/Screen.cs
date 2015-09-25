using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Client
{
    public abstract class Screen
    {
        protected MainWindow _mainWindow;

        public Screen()
        {
                
        }

        public Screen(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public abstract void Display();
        public abstract void Button_Keypad1();
        public abstract void Button_Keypad2();
        public abstract void Button_Keypad3();
        public abstract void Button_Keypad4();
        public abstract void Button_Keypad5();
        public abstract void Button_Keypad6();
        public abstract void Button_Keypad7();
        public abstract void Button_Keypad8();
        public abstract void Button_Keypad9();
        public abstract void Button_Keypad0();
        public abstract void Button_KeypadEnter();
        public abstract void Button_KeypadCancel();
        public abstract void Button_KeypadClear();
        public abstract void Button_L1();
    }
}
