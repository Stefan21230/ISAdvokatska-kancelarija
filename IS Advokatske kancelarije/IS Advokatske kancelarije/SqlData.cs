using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace IS_Advokatske_kancelarije
{
    class SqlData
    {

        public SqlData() { }

        public bool StrankeDodavanje(Stranke stranke)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=bazaTest.db3;Version=3;");
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                String query = "INSERT INTO stranke(id,ime,prezime,jmbg,datum,predmet,broj) values('" + stranke.Id + "', '" + stranke.Ime + "', '" + stranke.Prezime + "', '" + stranke.Jmbg + "', '" + stranke.DatumRodjenja + "', '" + stranke.Predmet + "', '" + stranke.BrojTelefona + "' ) ";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool StrankeBrisanje(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=bazaTest.db3;Version=3;");
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                String query = "DELETE FROM stranke WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
            
        public bool DodavanjeZaduzenja(Zaduzenje zaduzenje)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=bazaTest.db3;Version=3;");
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                String query = "INSERT INTO zaduzenja(id,idStranke,datumZaduzenja,zaduzenje,razduzenje)values('" + zaduzenje.Id + "','" + zaduzenje.IdStranke + "','" + zaduzenje.DatumZaduzenja + "','" + zaduzenje.Zaduzenja + "','" + zaduzenje.Razduzenje + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool BrisanjeZaduzenja(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=bazaTest.db3;Version=3;");
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {

                String query = "DELETE FROM zaduzenja WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }



    }
}
