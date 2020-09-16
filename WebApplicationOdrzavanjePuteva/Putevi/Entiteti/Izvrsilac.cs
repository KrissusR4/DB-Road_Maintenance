using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Izvrsilac:Radnik
    {
        public virtual IList<Upravlja> Upravlja { get; set; }
        public virtual IList<RadiNa> RadiNa { get; set; }
        public virtual IList<Deonica> Deonice { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public virtual string Specijalnost { get; set; }

        public Izvrsilac()
        {
            Upravlja = new List<Upravlja>();
            RadiNa = new List<RadiNa>();
            Deonice = new List<Deonica>();
            Vozila = new List<Vozilo>();
        }

    }
}
