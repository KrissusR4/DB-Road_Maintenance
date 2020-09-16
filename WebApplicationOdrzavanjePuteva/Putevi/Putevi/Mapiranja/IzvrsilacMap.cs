using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class IzvrsilacMap:SubclassMap<Izvrsilac>
    {
        public IzvrsilacMap()
        {
            Table("IZVRSILAC");

            Schema("S16103");

            KeyColumn("ID_RADNIK");

            HasMany(x => x.Vozila)
             .Cascade.All().KeyColumn("REG_OZNAKA")
             .Inverse()
             .Table("UPRAVLJA");

            HasMany(x => x.Deonice)
            .Cascade.All().KeyColumn("ID_DEONICE").KeyColumn("ID_GRADILISTA")
            .Inverse()
            .Table("RADI_NA");
        }
    }
}
