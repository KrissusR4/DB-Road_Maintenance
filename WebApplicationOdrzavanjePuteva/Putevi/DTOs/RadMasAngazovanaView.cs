using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class RadMasAngazovanaView
    {
        public int IdAngazovanje { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string RadnaMasina { get; set; }
        public int Deonica { get; set; }

        public RadMasAngazovanaView(RadMasAngazovana rm)
        {
            this.IdAngazovanje = rm.IdAngazovanje;
            this.DatumOd = rm.DatumOd;
            this.DatumDo = rm.DatumDo;
            this.RadnaMasina = rm.RadneMasine.RegOznaka;
            this.Deonica = rm.Deonice.IdDeonice;
        }
    }
}
