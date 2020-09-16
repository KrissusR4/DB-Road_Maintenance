using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class GradilisteMap:ClassMap<Gradiliste>
    {
        public GradilisteMap()
        {
            Table("GRADILISTE");

            Schema("S16103");

            Id(x => x.IdGradilista, "ID_GRADILISTA").GeneratedBy.TriggerIdentity();

            References(x => x.Preduzece, "ID_PREDUZECA");
            
            Map(x => x.Tip, "TIP");

            HasMany(x => x.Deonice)
              .Cascade.All().KeyColumn("ID_GRADILISTA")
              .Inverse()
              .Table("DEONICA");
        }
    }
}
