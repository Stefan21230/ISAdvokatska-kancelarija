using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Advokatske_kancelarije
{
    class Zaduzenje
    {
        private int id;
        private int idStranke;
        private double zaduzenja;
        private string datumZaduzenja;
        private double razduzenje;


        public Zaduzenje()
        {

        }

        public Zaduzenje(int id, int idStranke, double zaduzenja, string datumZaduzenja, double razduzenje)
        {
            Id = id;
            IdStranke = idStranke;
            Zaduzenja = zaduzenja;
            DatumZaduzenja = datumZaduzenja;
            Razduzenje = razduzenje;


        }

        public int Id {get => id; set => id = value;}
        public int IdStranke { get => idStranke; set => idStranke = value; }
        public double Zaduzenja { get => zaduzenja; set => zaduzenja = value; }
        public string DatumZaduzenja { get => datumZaduzenja; set => datumZaduzenja = value; }
        public double Razduzenje { get => razduzenje; set => razduzenje = value; }


    }
}
