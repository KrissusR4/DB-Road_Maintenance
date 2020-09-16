using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Gradiliste
    {
        public virtual int IdGradilista { get; set; }
        public virtual string Tip { get; set; }
        public virtual Preduzece Preduzece { get; set; }

        public virtual IList<Deonica> Deonice { get; set; }

        public Gradiliste()
        {
            Deonice = new List<Deonica>();
        }
    }
}
