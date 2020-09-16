using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class RadMasAngazovanaMap:ClassMap<RadMasAngazovana>
    {
        public RadMasAngazovanaMap()
        {
            Table("RADMAS_ANGAZOVANA");

            Schema("S16103");

            Id(x => x.IdAngazovanje, "ID_ANGAZOVANJA").GeneratedBy.SequenceIdentity("ID_RADMAS_ANG_SEQ");

            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");

            References(x => x.Deonice).Column("ID_DEONICE");
            References(x => x.RadneMasine).Column("REG_OZNAKA");
        }

    }
}
