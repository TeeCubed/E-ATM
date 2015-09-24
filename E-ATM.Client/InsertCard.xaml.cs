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
                MainWindow.lbl_M1.FontSize = 20;
                MainWindow.lbl_M1.Content = "Enter Pin: ";

                MainWindow.lbl_M2.Content = "";
                double thickness = MainWindow.lbl_M2.BorderThickness.Bottom + 3;
                MainWindow.lbl_M2.BorderThickness = new Thickness(thickness);
            }
            else
            {
                MainWindow.lbl_M2.FontSize = 20;
                MainWindow.lbl_M2.Content = "Invalid Card!";
            }

            this.Close();
        }
    }
}
