using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class RadiNa
    {
        public virtual int IdRadniNa { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }

        public virtual Vozilo Vozilo { get; set; }
        public virtual Radnik Radnik { get; set; }
        public virtual Gradiliste Gradiliste { get; set; }
    }
}
