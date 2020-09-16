using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class DuziMap:ClassMap<Duzi>
    {
        public DuziMap()
        {
            Table("DUZI");

            Schema("S16103");

            Id(x => x.IdDuzenja, "ID_DUZENJA").GeneratedBy.TriggerIdentity();

            References(x => x.PutnickoVozilo, "REG_OZNAKA");
            References(x => x.Nadzornik, "ID_RADNIK");

            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
        }
    }
}
