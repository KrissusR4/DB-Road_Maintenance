using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class VoziloMap: ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("VOZILO");

            Schema("S16103");

            Id(x => x.RegOznaka, "REG_OZNAKA").GeneratedBy.Assigned();

            References(x => x.Preduzece).Column("ID_PREDUZECE");

            // properties
            Map(x => x.Gorivo, "GORIVO");
            Map(x => x.ZapreminaMotora, "ZAPREMINA_MOTORA");
            Map(x => x.Boja, "BOJA");
            Map(x => x.TipVozila, "TIP_VOZILA");

            HasMany(x => x.Upravlja).KeyColumn("REG_OZNAKA").Cascade.All().Inverse();
             

            HasManyToMany(x => x.Izvrsioci).Table("UPRAVLJA").ParentKeyColumn("REG_OZNAKA").ChildKeyColumn("ID_RADNIK").Cascade.All();

        }
    }
}
