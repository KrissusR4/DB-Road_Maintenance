using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Duzi
    {
        public virtual int IdDuzenja { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        
        public virtual Putnicko PutnickaVozila { get; set; }
        public virtual Nadzornik Nadzornici { get; set; }

        

    }
}
