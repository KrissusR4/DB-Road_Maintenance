using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Nadzornik : Radnik
    {
        public virtual DateTime DatumPostavljanja { get; set; }

        public virtual IList<SpoljniSaradnik> SpoljniSaradnici { get; set; }
        public virtual IList<Duzi> PutnickaVozila { get; set; }

        public Nadzornik()
        {
            SpoljniSaradnici = new List<SpoljniSaradnik>();
            PutnickaVozila = new List<Duzi>();
        }
    }
}
