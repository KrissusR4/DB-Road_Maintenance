using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class SpoljniSaradnikMap:ClassMap<SpoljniSaradnik>
    {
        public SpoljniSaradnikMap()
        {
            Table("SPOLJNI_SARADNIK");

            Schema("S16103");

          

           CompositeId()
                 .KeyProperty(x => x.BrUgovoraODelu,"BROJ_UGOVORA_O_DELU")
                 .KeyReference(x => x.Nadzornik, "ID_RADNIK");

            Map(x => x.Ime,"IME");
            Map(x => x.Prezime, "PREZIME");

        }
    }
}
