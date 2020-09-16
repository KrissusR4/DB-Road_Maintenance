using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class RadiNa
    {
        
        public virtual int RadiNaId { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }

        public virtual Deonica Deonice { get; set; }
        public virtual Izvrsilac Izvrsioci { get; set; }

      

    }
}
