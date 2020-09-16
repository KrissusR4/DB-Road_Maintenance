using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class RadnaMasina:Vozilo
    {
        public virtual string Tip { get; set; }
        public virtual string TipPogona { get; set; }

        public virtual IList<RadMasAngazovana> RadMasAng { get; set; }
        public virtual IList<Deonica> Deonice { get; set; }

        public RadnaMasina()
        {
            RadMasAng = new List<RadMasAngazovana>();
            Deonice = new List<Deonica>();
        }
    }
}
