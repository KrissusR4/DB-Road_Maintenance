using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class RadiNaMap:ClassMap<RadiNa>
    {
        public RadiNaMap()
        {
            Table("RADI_NA");

            Schema("S16103");

            Id(x => x.RadiNaId, "ID_RADI_NA").GeneratedBy.SequenceIdentity("ID_RADI_NA_SEQ");

            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");

            References(x => x.Deonice).Column("ID_DEONICE");
            References(x => x.Izvrsioci).Column("ID_RADNIK");
        }
    }
}
