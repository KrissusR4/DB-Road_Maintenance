using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Putnicko : Vozilo
    {
        public virtual int BrojMesta { get; set; }
        public virtual IList<Duzi> Duzenja { get; set; }
        public Putnicko()
        {
            Duzenja = new List<Duzi>();
        }
    }
}
