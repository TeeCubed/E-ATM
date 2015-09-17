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
        private ATM atm;

        public MainWindow()
        {
            InitializeComponent();

            atm = new ATM();
        }

        private void btn_InsertCard_Click(object sender, RoutedEventArgs e)
        {
            Card card = new Card();

            var guid = Guid.NewGuid();

            card.Id = guid;
            card.Status = CardStatus.Active;


            var validateResult = atm.ValidateCard(card);

            if (validateResult)
            {
                txt_Screen.Text = "Enter Pin: ";
            }
            else
            {
                txt_Screen.Text = "Invalid Card!";
            }
        }
    }
}
