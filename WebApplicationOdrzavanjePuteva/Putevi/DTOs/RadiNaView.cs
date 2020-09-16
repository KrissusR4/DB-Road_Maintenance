using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class RadiNaView
    {
        public int RadiNaId { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int Deonica { get; set; }
        public string Izvrsilac { get; set; }

        public RadiNaView(RadiNa rn)
        {
            this.RadiNaId = rn.RadiNaId;
            this.DatumOd = rn.DatumOd;
            this.DatumDo = rn.DatumDo;
            this.Deonica = rn.Deonice.IdDeonice;
            this.Izvrsilac = rn.Izvrsioci.Ime;
        }
    }
}
