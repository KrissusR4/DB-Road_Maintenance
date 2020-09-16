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
        public virtual IList<RadMasAngazovana> RadneMasine { get; set; }
        public RadnaMasina()
        {
            RadneMasine = new List<RadMasAngazovana>();
        }
    }
}
