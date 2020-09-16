using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class VoziloView
    {
        public string RegOznaka { get; set; }
        public string Gorivo { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public string TipVozila { get; set; }
       // public string Preduzece { get; set; }
        public int BrojIzvsilaca { get; set; }

        public VoziloView(Vozilo v)
        {
            this.RegOznaka = v.RegOznaka;
            this.Gorivo = v.Gorivo;
            this.Boja = v.Boja;
            this.ZapreminaMotora = v.ZapreminaMotora;
            this.TipVozila = v.TipVozila;
            //this.Preduzece = v.Preduzece.Naziv;
            this.BrojIzvsilaca = v.Izvrsioci.Count;
        }
    }
}
