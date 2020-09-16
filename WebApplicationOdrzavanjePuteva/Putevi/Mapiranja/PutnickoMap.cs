using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class PutnickoMap:SubclassMap<Putnicko>
    {
        public PutnickoMap()
        {
            Table("PUTNICKO");

            Schema("S16103");

            KeyColumn("REG_OZNAKA");

            Map(x => x.BrojMesta, "BROJ_MESTA");

            HasMany(x => x.Duzenja)
             .KeyColumn("REG_OZNAKA").Cascade.All()
             .LazyLoad()
             .Inverse();

            HasManyToMany(x => x.Nadzornici)
                .Table("DUZI")
                .ParentKeyColumn("REG_OZNAKA")
                .ChildKeyColumn("ID_RADNIK")
                .Cascade.All();



        }
    }
}
