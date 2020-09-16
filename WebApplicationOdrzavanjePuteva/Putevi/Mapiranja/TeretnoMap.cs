using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;
namespace Putevi.Mapiranja
{
    public class TeretnoMap: SubclassMap<Teretno>
    {
        public TeretnoMap()
        {
            Table("TERETNO");

            Schema("S16103");

            KeyColumn("REG_OZNAKA");

            Map(x => x.BrojOsovina, "BROJ_OSOVINA");
            Map(x => x.Nosivost, "NOSIVOST");

            HasMany(x => x.TeretnoAng)
             .KeyColumn("REG_OZNAKA").Cascade.All()
             .Inverse()
             .LazyLoad();

            HasManyToMany(x => x.Deonice)
                .Table("TERETNO_ANGAZOVANO")
                .ParentKeyColumn("REG_OZNAKA")
                .ChildKeyColumn("ID_DEONICE")
                .Inverse()
                .Cascade.All();

        }
    }
}
