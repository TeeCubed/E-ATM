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
using System.Windows.Shapes;
using E_ATM.Library;

namespace E_ATM.Client
{
    /// <summary>
    /// Interaction logic for InsertCard.xaml
    /// </summary>
    public partial class InsertCard : Window
    {
        public Card InsertedCard { get; set; }
        public MainWindow MainWindow { get; set; }

        public InsertCard(MainWindow mainWindow)
        {
            InitializeComponent();

            MainWindow = mainWindow;
        }

        public void btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            InsertedCard = new Card();

            InsertedCard.Id = Guid.NewGuid();
            InsertedCard.Status = CardStatus.Active;
            InsertedCard.Bin = txt_first4.Text + txt_second4.Text + txt_third4.Text + txt_last4.Text;

            var validateResult = MainWindow.Atm.ValidateCard(InsertedCard);


            if (validateResult)
            {
                MainWindow.txt_Screen.Text = "Enter Pin: ";
            }
            else
            {
                MainWindow.txt_Screen.Text = "Invalid Card!";
            }

            this.Close();

        }
    }
}
