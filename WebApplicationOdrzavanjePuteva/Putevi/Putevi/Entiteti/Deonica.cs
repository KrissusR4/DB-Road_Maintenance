using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Deonica
    {
        public virtual int IdDeonice { get; set; }
        public virtual string KrajnjiGrad { get; set; }
        public virtual string PocetniGrad { get; set; }
        public virtual string PocetniKilometar { get; set; }
        public virtual string ZavrsniKilometar { get; set; }

        public virtual Gradiliste Gradiliste { get; set; }
        
        public virtual IList<RadMasAngazovana> RadneMasine { get; set; }
        public virtual IList<TeretnoAngazovano> TeretnaVozila { get; set; }
        public virtual IList<RadiNa> Izvrsioci { get; set; }

        public Deonica()
        {
            RadneMasine = new List<RadMasAngazovana>();
            TeretnaVozila = new List<TeretnoAngazovano>();
            Izvrsioci = new List<RadiNa>();
        }

    }
}
