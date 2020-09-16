using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class UpravljaMap:ClassMap<Upravlja>
    {
        public UpravljaMap()
        {
            Table("UPRAVLJA");

            Schema("S16103");

            Id(x => x.IdUpravljanja, "ID_UPRAVLJANJA").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
            References(x => x.Vozilo).Column("REG_OZNAKA");
            References(x => x.Izvrsilac).Column("ID_RADNIK");
        }

    }
}
