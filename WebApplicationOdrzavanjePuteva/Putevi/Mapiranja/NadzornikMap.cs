using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class NadzornikMap:SubclassMap<Nadzornik>
    {
        public NadzornikMap()
        {
            Table("NADZORNIK");

            Schema("S16103");

            KeyColumn("ID_RADNIK");
           
            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");

            HasMany(x => x.SpoljniSaradnici)
            .KeyColumn("ID_RADNIK").Cascade.All()
            .Inverse()
            .LazyLoad();


            HasMany(x => x.Duzenja)
             .KeyColumn("ID_RADNIK").Cascade.All()
             .Inverse()
             .LazyLoad();

            HasManyToMany(x => x.PutnickaVozila)
                .Table("DUZI")
                .ParentKeyColumn("ID_RADNIK")
                .ChildKeyColumn("REG_OZNAKA")
                .Inverse()
                .Cascade.All();
        }
    }
}
