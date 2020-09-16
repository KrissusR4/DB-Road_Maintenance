using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class UpravljaView
    {
        public int IdUpravljanja { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Vozilo { get; set; }
        public int Izvrsilac { get; set; }

        public UpravljaView(Upravlja u)
        {
            this.IdUpravljanja = u.IdUpravljanja;
            this.DatumOd = u.DatumOd;
            this.DatumDo = u.DatumDo;
            this.Vozilo = u.Vozilo.RegOznaka;
            this.Izvrsilac = u.Izvrsilac.IdRadnik;
        }
    }
}
