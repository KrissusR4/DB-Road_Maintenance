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
            

            Map(x => x.Specijalnost, "SPECIJALNOST");

            HasMany(x => x.Upravlja)
             .KeyColumn("ID_RADNIK").Cascade.All()
             .Inverse()
             .LazyLoad();

            HasManyToMany(x => x.Vozila)
                .Table("UPRAVLJA")
                .ParentKeyColumn("ID_RADNIK")
                .ChildKeyColumn("REG_OZNAKA")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.RadiNa)
             .KeyColumn("ID_RADNIK").Cascade.All()
             .Inverse()
             .LazyLoad();

            HasManyToMany(x => x.Deonice)
                .Table("RADI_NA")
                .ParentKeyColumn("ID_RADNIK")
                .ChildKeyColumn("ID_DEONICE")
                .Inverse()
                .Cascade.All();
        }

    }
}
