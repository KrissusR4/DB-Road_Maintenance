using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Upravlja
    {
        public virtual int IdUpravljanja { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }

        public virtual Vozilo Vozilo { get; set; }
        public virtual Izvrsilac Izvrsilac { get; set; }
    }
}
