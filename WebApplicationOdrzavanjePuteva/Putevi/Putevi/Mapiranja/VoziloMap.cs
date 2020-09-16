using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class VoziloMap: ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("VOZILO");
            Schema("S16103");

            Id(x => x.RegOznaka, "REG_OZNAKA").GeneratedBy.Assigned();

            // properties
            Map(x => x.Gorivo, "GORIVO");
            Map(x => x.ZapreminaMotora, "ZAPREMINA_MOTORA");
            Map(x => x.Boja, "BOJA");

            References(x => x.Vozilo, "REG_OZNAKA");
            References(x => x.Izvrsilac, "ID_RADNIK");


        }
    }
}
