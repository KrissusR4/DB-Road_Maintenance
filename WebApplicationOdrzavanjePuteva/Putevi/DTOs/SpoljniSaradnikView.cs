using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class SpoljniSaradnikView
    {
        public int BrUgovoraODelu { get; set; }
        public int Nadzornik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public SpoljniSaradnikView(SpoljniSaradnik ss)
        {
            this.BrUgovoraODelu = ss.BrUgovoraODelu;
            this.Nadzornik = ss.Nadzornik.IdRadnik;
            this.Ime = ss.Ime;
            this.Prezime = ss.Prezime;
        }
    }
}
