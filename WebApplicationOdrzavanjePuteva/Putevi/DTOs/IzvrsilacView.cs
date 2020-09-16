using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class IzvrsilacView
    {
        public int IdRadnik { get; set; }
        public Int64 JMBG { get; set; }
        public string FullName { get; set; }
        public int GodRodj { get; set; }
        public string TipPosla { get; set; }
        public string Adresa { get; set; }
        public string Specijalnost { get; set; }
        public int BrojDeonica { get; set; }
        public int BrojVozila { get; set; }

        public IzvrsilacView(Izvrsilac i)
        {
            this.IdRadnik = i.IdRadnik;
            this.JMBG = i.JMBG;
            this.FullName =i.Ime + " " + i.Prezime; ;
            this.GodRodj = i.GodRodj;
            this.Adresa = i.Adresa;
            this.TipPosla = i.TipPosla;
          
            this.Specijalnost = i.Specijalnost;
            this.BrojDeonica = i.Deonice.Count;
            this.BrojVozila = i.Vozila.Count;
        }
    }
}
