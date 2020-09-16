using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class TeretnoAngazovano
    {
       
        public virtual int IdAngazovanje { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }

        public virtual Teretno Teretna { get; set; }
        public virtual Deonica Deonice { get; set; }

       

    }
}
