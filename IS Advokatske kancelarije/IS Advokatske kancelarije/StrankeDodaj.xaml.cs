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
using System.Data;
using System.Data.SQLite;

namespace IS_Advokatske_kancelarije
{
    /// <summary>
    /// Interaction logic for StrankeDodaj.xaml
    /// </summary>
    public partial class StrankeDodaj : Window
    {
        public StrankeDodaj()
        {
            InitializeComponent();
        }

        private void Otkazi_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }

        private void Sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            if (Validacija())
            {
                Stranke stranke = new Stranke(int.Parse(idStrankeTextBox.Text), imeTextBox.Text, prezimeTextBox.Text, int.Parse(jmbgTextBox.Text), datumTextBox.Text, predmetTextBox.Text, int.Parse(brojTelefonaTextBox.Text));
                SqlData sql = new SqlData();
                if (sql.StrankeDodavanje(stranke) == true)
                { 
                    MessageBox.Show("Polja su pravilno dodata u bazu", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                 else
                MessageBox.Show("Polja NISU pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void ResetFields()
        {
            idStrankeTextBox.Text = "";
            imeTextBox.Text = "";
            prezimeTextBox.Text = "";
            jmbgTextBox.Text = "";
            brojTelefonaTextBox.Text = "";
            predmetTextBox.Text = "";
            datumTextBox.Text = "";

            idStrankeTextBox.Background = null;
            imeTextBox.Background = null;
            prezimeTextBox.Background = null;
            jmbgTextBox.Background = null;
            brojTelefonaTextBox.Background = null;
            predmetTextBox.Background = null;
            datumTextBox.Background = null;

        }

        private bool Validacija()
        {

            bool ver1 = false;
            bool ver2 = false;
            bool ver3 = false;
            bool ver4 = false;
            bool ver5 = false;
            bool ver6 = false;
            bool ver7 = false;

            if (string.IsNullOrEmpty(idStrankeTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idStrankeTextBox.Text, "[^0-9]"))
            {
                idStrankeTextBox.Background = Brushes.Red;
                ver1 = false;
            }
            else
            {
                idStrankeTextBox.Background = null;
                ver1 = true;
            }
            if (string.IsNullOrEmpty(imeTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(imeTextBox.Text, "[^A-ž]"))
            {
                imeTextBox.Background = Brushes.Red;
                ver2 = false;
            }
            else
            {
                imeTextBox.Background = null;
                ver2 = true;
            }
            if (string.IsNullOrEmpty(prezimeTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(prezimeTextBox.Text, "[^A-ž]"))
            {
                prezimeTextBox.Background = Brushes.Red;
                ver3 = false;
            }
            else
            {
                prezimeTextBox.Background = null;
                ver3 = true;
            }
            if (string.IsNullOrEmpty(jmbgTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(jmbgTextBox.Text, "[^0-9]"))
            {
                jmbgTextBox.Background = Brushes.Red;
                ver4 = false;
            }
            else
            {
                jmbgTextBox.Background = null;
                ver4 = true;
            }
            if (string.IsNullOrEmpty(brojTelefonaTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(brojTelefonaTextBox.Text, "[^0-9]"))
            {
                brojTelefonaTextBox.Background = Brushes.Red;
                ver5 = false;
            }
            else
            {
                brojTelefonaTextBox.Background = null;
                ver5 = true;
            }
            if (string.IsNullOrEmpty(predmetTextBox.Text))
            {
                predmetTextBox.Background = Brushes.Red;
                ver6 = false;
            }
            else
            {
                predmetTextBox.Background = null;
                ver6 = true;
            }
            if (string.IsNullOrEmpty(datumTextBox.Text))
            {
                predmetTextBox.Background = Brushes.Red;
                ver7 = false;
            }
            else
            {
                predmetTextBox.Background = null;
                ver7 = true;
            }

            if (ver1 && ver2 && ver3 && ver4 && ver5 && ver6 && ver7)
                return true;
            else return false;
        }

    }
}
