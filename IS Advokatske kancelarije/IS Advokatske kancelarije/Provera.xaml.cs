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
    /// Interaction logic for Provera.xaml
    /// </summary>
    public partial class Provera : Window
    {
        public Provera()
        {
            InitializeComponent();
        }

    private void Ucitaj()
        {
            // prvo povezivanje na bazu
            // slanje upita (select, delete ili slicno)
            // cuvanje podataka u data adapteru
            // prepisivanje iz data adaptera u data set - za cuvanje podataka u c#
            // podaci iz data seta se ispisuju u data gridu

            SQLiteConnection con = new SQLiteConnection("Data Source=bazaTest.db3;Version=3;");
            con.Open();
            SQLiteCommand sql_cmd = con.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM stranke";
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, con);
            DataSet DS = new DataSet();
            DB.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {
                StrankeDataGrid.ItemsSource = DS.Tables[0].DefaultView;
            }
            con.Close();



        }

        private void UcitajZaduzenja()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=bazaTest.db3;Version=3;");
            con.Open();
            SQLiteCommand sql_cmd = con.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM pogled_zaduzenje";
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, con);
            DataSet DS = new DataSet();
            DB.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {
                zaduzenjaDataGrid.ItemsSource = DS.Tables[0].DefaultView;
            }
            con.Close();
        }

        private void RefreshStranke_Click(object sender, RoutedEventArgs e)
        {
            Ucitaj();
        }

        private void RefreshZaduzenja_Click(object sender, RoutedEventArgs e)
        {
            UcitajZaduzenja();
        }



        private void Stranke_Click(object sender, RoutedEventArgs e)
        {
            StrankeDataGrid.Visibility = Visibility.Visible;
            zaduzenjaDataGrid.Visibility = Visibility.Hidden;
            refreshStranke.Visibility = Visibility.Visible;
            refreshZaduzenja.Visibility = Visibility.Hidden;
            DodajStranke.Visibility = Visibility.Visible;
            dodajZaduzenja.Visibility = Visibility.Hidden;
            izmeniStranke.Visibility = Visibility.Visible;
            izmeniZaduzenja.Visibility = Visibility.Hidden;
            obrisiStranke.Visibility = Visibility.Visible;
            obrisiZaduzenja.Visibility = Visibility.Hidden;

            Ucitaj();

        }

        private void Zaduzenja_Click(object sender, RoutedEventArgs e)
        {
            zaduzenjaDataGrid.Visibility = Visibility.Visible;
            StrankeDataGrid.Visibility = Visibility.Hidden;
            refreshZaduzenja.Visibility = Visibility.Visible;
            refreshStranke.Visibility = Visibility.Hidden;
            DodajStranke.Visibility = Visibility.Hidden;
            dodajZaduzenja.Visibility = Visibility.Visible;
            izmeniStranke.Visibility = Visibility.Hidden;
            izmeniZaduzenja.Visibility = Visibility.Visible;
            obrisiStranke.Visibility = Visibility.Hidden;
            obrisiZaduzenja.Visibility = Visibility.Visible;

            UcitajZaduzenja();
        }

        private void DodajStranke_Click(object sender, RoutedEventArgs e)
        {
            StrankeDodaj strankeDodaj = new StrankeDodaj();
            strankeDodaj.Show();
        }

        private void  ObrisiStranke_Click(object sender, RoutedEventArgs e)
        {
            StrankeObrisi strankeObrisi = new StrankeObrisi();
            strankeObrisi.Show();
        }

        private void DodajZaduzenja_Click(object sender, RoutedEventArgs e)
        {
            ZaduzenjaDodaj zaduzenjaDodaj = new ZaduzenjaDodaj();
            zaduzenjaDodaj.Show();
        }

        private void ObrisiZaduzenja_Click(object sender, RoutedEventArgs e)
        {
            ZaduzenjaObrisi zaduzenjaObrisi = new ZaduzenjaObrisi();
            zaduzenjaObrisi.Show();
        }
    }

}
