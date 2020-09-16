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
        
        public virtual IList<RadMasAngazovana> RadMasAng { get; set; }
        public virtual IList<TeretnoAngazovano> TeretnoAng { get; set; }
        public virtual IList<RadiNa> RadiNa { get; set; }
        public virtual IList<RadnaMasina> RadneMasine { get; set; }
        public virtual IList<Teretno> Teretna { get; set; }
        public virtual IList<Izvrsilac> Izvrsioci { get; set; }

        public Deonica()
        {
            RadMasAng = new List<RadMasAngazovana>();
            TeretnoAng = new List<TeretnoAngazovano>();
            RadiNa = new List<RadiNa>();
            RadneMasine = new List<RadnaMasina>();
            Teretna = new List<Teretno>();
            Izvrsioci = new List<Izvrsilac>();
        }

    }
}
