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

namespace IS_Advokatske_kancelarije
{
    /// <summary>
    /// Interaction logic for ZaduzenjaDodaj.xaml
    /// </summary>
    public partial class ZaduzenjaDodaj : Window
    {
        public ZaduzenjaDodaj()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validacija())
            {
                Zaduzenje zaduzenje = new Zaduzenje(int.Parse(idTextBox.Text), int.Parse(idStrankeTextBox.Text), double.Parse(zaduzenjeTextBox.Text), datumTextBox.Text ,double.Parse(razduzenjeTextBox.Text));
                SqlData sql = new SqlData();
                if (sql.DodavanjeZaduzenja(zaduzenje) == true)
                {
                    MessageBox.Show("Polja su pravilno dodata u bazu", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                    MessageBox.Show("Polja NISU pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);


            }
        }

        private bool Validacija()
        {

            bool ver1 = false;
            bool ver2 = false;
            bool ver3 = false;
            bool ver4 = false;
            bool ver5 = false;

            if (string.IsNullOrEmpty(idTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idTextBox.Text, "[^0-9]"))
            {
                idTextBox.Background = Brushes.Red;
                ver1 = false;
            }
            else
            {
                idTextBox.Background = null;
                ver1 = true;
            }
            if (string.IsNullOrEmpty(idStrankeTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idStrankeTextBox.Text, "[^0-9]"))
            {
                idStrankeTextBox.Background = Brushes.Red;
                ver2 = false;
            }
            else
            {
                idStrankeTextBox.Background = null;
                ver2 = true;
            }
            if (string.IsNullOrEmpty(datumTextBox.Text))
            {
                datumTextBox.Background = Brushes.Red;
                ver3 = false;
            }
            else
            {
                datumTextBox.Background = null;
                ver3 = true;
            }
            if (string.IsNullOrEmpty(zaduzenjeTextBox.Text))
            {
                zaduzenjeTextBox.Background = Brushes.Red;
                ver4 = false;
            }
            else
            {
                zaduzenjeTextBox.Background = null;
                ver4 = true;
            }
            if (string.IsNullOrEmpty(razduzenjeTextBox.Text))
            {
                razduzenjeTextBox.Background = Brushes.Red;
                ver5 = false;
            }
            else
            {
                razduzenjeTextBox.Background = null;
                ver5 = true;
            }

            if (ver1 && ver2 && ver3 && ver4 && ver5)
                return true;
            else return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
