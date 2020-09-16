using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class SpoljniSaradnik
    {
        public virtual int BrUgovoraODelu { get; set; }
        public virtual Nadzornik Nadzornik {get; set;}
    }
}
