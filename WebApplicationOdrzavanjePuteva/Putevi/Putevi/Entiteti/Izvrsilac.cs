using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Izvrsilac:Radnik
    {
        public virtual IList<Upravlja> Vozila { get; set; }
        public virtual IList<RadiNa> Deonice { get; set; }
        public Izvrsilac()
        {
            Vozila = new List<Upravlja>();
            Deonice = new List<RadiNa>();
        }

    }
}
