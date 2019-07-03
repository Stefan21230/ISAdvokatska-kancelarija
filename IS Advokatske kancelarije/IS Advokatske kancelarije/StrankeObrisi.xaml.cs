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
    /// Interaction logic for StrankeObrisi.xaml
    /// </summary>
    public partial class StrankeObrisi : Window
    {
        public StrankeObrisi()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validacija())
            {
                SqlData sql = new SqlData();
                if (sql.StrankeBrisanje(int.Parse(idKlijenatTextBox.Text)) == true)
                {
                    MessageBox.Show("Kolona je uspešno obrisana", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Polja NISU pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void ResetFields()
        {
            idKlijenatTextBox.Text = "";
            idKlijenatTextBox.Background = null;
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(idKlijenatTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idKlijenatTextBox.Text, "[^0-9]"))
            {
                idKlijenatTextBox.Background = Brushes.Red;
                return false;
            }
            else
            {
                idKlijenatTextBox.Background = null;
                return true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
