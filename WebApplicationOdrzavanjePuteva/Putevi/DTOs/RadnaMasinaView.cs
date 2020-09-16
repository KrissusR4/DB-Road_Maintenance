using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class RadnaMasinaView
    {
        public string RegOznaka { get; set; }
        public string Gorivo { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public string Tip { get; set; }
        public string TipPogona { get; set; }
        public int BrojDeonica { get; set; }

        public RadnaMasinaView(RadnaMasina rm)
        {
            this.RegOznaka = rm.RegOznaka;
            this.Gorivo = rm.Gorivo;
            this.Boja = rm.Boja;
            this.ZapreminaMotora = rm.ZapreminaMotora;
            this.Tip = rm.Tip;
            this.TipPogona = rm.TipPogona;
            this.BrojDeonica = rm.Deonice.Count;
        }
    }
}
