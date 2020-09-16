using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class TeretnoView
    {
        public string RegOznaka { get; set; }
        public string Gorivo { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public int BrojOsovina { get; set; }
        public int Nosivost { get; set; }
        public int Deonice { get; set; }

        public TeretnoView(Teretno t)
        {
            this.RegOznaka = t.RegOznaka;
            this.Gorivo = t.Gorivo;
            this.Boja = t.Boja;
            this.ZapreminaMotora = t.ZapreminaMotora;
            this.BrojOsovina = t.BrojOsovina;
            this.Nosivost = t.Nosivost;
            this.Deonice = t.Deonice.Count;
        }
    }
}
