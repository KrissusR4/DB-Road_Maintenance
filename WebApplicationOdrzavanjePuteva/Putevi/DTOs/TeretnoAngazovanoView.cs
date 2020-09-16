using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class TeretnoAngazovanoView
    {
        public int IdAngazovanje { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Teretno { get; set; }
        public int Deonica { get; set; }

        public TeretnoAngazovanoView(TeretnoAngazovano ta)
        {
            this.IdAngazovanje = ta.IdAngazovanje;
            this.DatumOd = ta.DatumOd;
            this.DatumDo = ta.DatumDo;
            this.Teretno = ta.Teretna.RegOznaka;
            this.Deonica = ta.Deonice.IdDeonice;
        }
    }
}
