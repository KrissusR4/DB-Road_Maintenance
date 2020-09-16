using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class GradilisteMap:ClassMap<Putevi.Entiteti.Gradiliste>
    {
        public GradilisteMap()
        {
            Table("GRADILISTE");

            Schema("S16103");

            Id(x => x.IdGradilista, "ID_GRADILISTA").GeneratedBy.TriggerIdentity();
            Map(x => x.Tip, "TIP");

            References(x => x.Preduzece).Column("ID_PREDUZECE");
           
            HasMany(x => x.Deonice)
              .KeyColumn("ID_GRADILISTA").Cascade.All()
              .Inverse().LazyLoad();
        }
    }
}
