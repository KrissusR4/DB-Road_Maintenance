using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class RadnikView
    {
        public int IdRadnik { get; set; }
        public Int64 JMBG { get; set; }
        public string FullName { get; set; }
        public string Adresa { get; set; }
        public int GodRodj { get; set; }
        public string TipPosla { get; set; }
        public bool JeSef { get; set; }
   
        public RadnikView(Radnik r)
        {
            this.IdRadnik = r.IdRadnik;
            this.JMBG = r.JMBG;
            this.FullName = r.Ime+" "+r.Prezime;
            this.Adresa = r.Adresa;
            this.GodRodj = r.GodRodj;
            this.TipPosla = r.TipPosla;
            this.JeSef = r.JeSef;
           
        }
    }
}
