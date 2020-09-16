using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Teretno:Vozilo
    {
        public virtual int BrojOsovina { get; set; }
        public virtual int Nosivost { get; set; }
        public virtual IList<TeretnoAngazovano> Deonice { get; set; }

        public Teretno()
        {
            Deonice = new List<TeretnoAngazovano>();
        }
            
    }
}
