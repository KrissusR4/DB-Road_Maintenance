using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class PreduzeceView
    {
        public int IdPreduzeca { get; set; }
        public string Naziv { get; set; }

        public PreduzeceView(Preduzece p)
        {
            this.IdPreduzeca = p.IdPreduzeca;
            this.Naziv = p.Naziv;
        }
    }
}
