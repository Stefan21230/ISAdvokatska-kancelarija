using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Advokatske_kancelarije
{
    class Stranke
    {
        private int id;
        private string ime;
        private string prezime;
        private int jmbg;
        private string datumRodjenja;
        private string predmet;
        private int brojTelefona;



        public Stranke()
        {

        }

        public Stranke(int id, string ime, string prezime, int jmbg, string datumRodjenja, string predmet, int brojTelefona)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
            Predmet = predmet;
            BrojTelefona = brojTelefona;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime ; set => prezime = value; }
        public int Jmbg { get => jmbg ; set => jmbg  = value; }
        public string DatumRodjenja { get => datumRodjenja ; set => datumRodjenja  = value; }
        public string Predmet { get => predmet; set => predmet = value; }
        public int BrojTelefona { get => brojTelefona ; set => brojTelefona  = value; }

    }


}
