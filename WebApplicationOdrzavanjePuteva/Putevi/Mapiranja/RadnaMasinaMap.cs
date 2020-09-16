using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class RadnaMasinaMap:SubclassMap<RadnaMasina>
    {
        public RadnaMasinaMap()
        {
            Table("RADNA_MASINA");

            Schema("S16103");

            KeyColumn("REG_OZNAKA");

            Map(x => x.Tip, "TIP");
            Map(x => x.TipPogona, "TIP_POGONA");

            HasMany(x => x.RadMasAng)
             .KeyColumn("REG_OZNAKA").Cascade.All()
             .Inverse()
             .LazyLoad();

            HasManyToMany(x => x.Deonice)
                .Table("RADMAS_ANGAZOVANA")
                .ParentKeyColumn("REG_OZNAKA")
                .ChildKeyColumn("ID_DEONICE")
                .Inverse()
                .Cascade.All();

        }
    }
}
