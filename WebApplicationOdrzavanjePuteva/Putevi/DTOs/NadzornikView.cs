using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class NadzornikView
    {
        public int IdRadnik { get; set; }
        public Int64 JMBG { get; set; }
        public string FullName { get; set; }
        public int GodRodj { get; set; }
        public string TipPosla { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public int BrojSpoljnihSaradnika { get; set; }
        public int BrojPutnickihVozila { get; set; }

        public NadzornikView(Nadzornik n)
        {
            this.IdRadnik = n.IdRadnik;
            this.JMBG = n.JMBG;
            this.FullName = n.Ime + " " + n.Prezime; ;
            this.GodRodj = n.GodRodj;
            this.TipPosla = n.TipPosla;
            this.Adresa = n.Adresa;
            this.DatumPostavljanja = n.DatumPostavljanja;
            this.BrojSpoljnihSaradnika = n.SpoljniSaradnici.Count;
            this.BrojPutnickihVozila = n.PutnickaVozila.Count;
        }
    }
}
