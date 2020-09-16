using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class PutnickoView
    {
        public string RegOznaka { get; set; }
        public string Gorivo { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public int BrojMesta { get; set; }
        public int BrojNadzornikaKojiDuze { get; set; }

        public PutnickoView(Putnicko p)
        {
            this.RegOznaka = p.RegOznaka;
            this.Gorivo = p.Gorivo;
            this.Boja = p.Boja;
            this.ZapreminaMotora = p.ZapreminaMotora;
            this.BrojMesta = p.BrojMesta;
            this.BrojNadzornikaKojiDuze = p.Nadzornici.Count;
        }
    }
}
