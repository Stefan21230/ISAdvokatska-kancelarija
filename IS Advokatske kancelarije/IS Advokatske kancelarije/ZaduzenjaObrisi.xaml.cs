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
    /// Interaction logic for ZaduzenjaObrisi.xaml
    /// </summary>
    public partial class ZaduzenjaObrisi : Window
    {
        public ZaduzenjaObrisi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validacija())
            {
                SqlData sql = new SqlData();
                if (sql.BrisanjeZaduzenja(int.Parse(idZaduženjaTextBox.Text)) == true)
                {
                    MessageBox.Show("Kolona je uspešno obrisana", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Polja NISU pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(idZaduženjaTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idZaduženjaTextBox.Text, "[^0-9]"))
            {
                idZaduženjaTextBox.Background = Brushes.Red;
                return false;
            }
            else
            {
                idZaduženjaTextBox.Background = null;
                return true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
