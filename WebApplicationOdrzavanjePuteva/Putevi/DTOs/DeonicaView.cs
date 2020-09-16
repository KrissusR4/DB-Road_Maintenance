using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class DeonicaView
    {
        public int IdDeonice { get; set; }
        public string KrajnjiGrad { get; set; }
        public string PocetniGrad { get; set; }
        public string PocetniKilometar { get; set; }
        public string ZavrsniKilometar { get; set; }
        //public int IdGradilista { get; set; }

        public DeonicaView(Deonica d)
        {
            this.IdDeonice = d.IdDeonice;
            this.KrajnjiGrad = d.KrajnjiGrad;
            this.PocetniGrad = d.PocetniGrad;
            this.PocetniKilometar = d.PocetniKilometar;
            this.ZavrsniKilometar = d.ZavrsniKilometar;
            //this.IdGradilista = d.Gradiliste.IdGradilista;
        }
    }
}
