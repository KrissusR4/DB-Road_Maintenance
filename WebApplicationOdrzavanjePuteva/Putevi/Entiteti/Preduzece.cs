using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Preduzece
    {
        public virtual int IdPreduzeca { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<Gradiliste> Gradilista { get; set; }
        public virtual IList<Radnik> Radnici { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public Preduzece()
        {
            Gradilista = new List<Gradiliste>();
            Radnici = new List<Radnik>();
            Vozila = new List<Vozilo>();

        }
    }
}
