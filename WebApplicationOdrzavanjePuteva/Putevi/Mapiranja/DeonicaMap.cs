using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class DeonicaMap:ClassMap<Deonica>
    {
        public DeonicaMap()
        {
            Table("DEONICA");

            Schema("S16103");

            Id(x => x.IdDeonice, "ID_DEONICE").GeneratedBy.Sequence("ID_DEONICE_SEQ");

            Map(x => x.KrajnjiGrad, "KRAJNJI_GRAD");
            Map(x => x.PocetniGrad, "POCETNI_GRAD");
            Map(x => x.PocetniKilometar, "POCETNI_KM");
            Map(x => x.ZavrsniKilometar, "ZAVRSNI_KM");

            References(x => x.Gradiliste).Column("ID_GRADILISTA");

            HasMany(x => x.RadiNa).KeyColumn("ID_DEONICE").Cascade.All().Inverse().LazyLoad();

            HasManyToMany(x => x.Izvrsioci)
                .Table("RADI_NA")
                .ParentKeyColumn("ID_DEONICE")
                .ChildKeyColumn("ID_RADNIK")
                .Cascade.All();

            HasMany(x => x.TeretnoAng)
             .KeyColumn("ID_DEONICE").Cascade.All().Inverse().LazyLoad();

            HasManyToMany(x => x.Teretna)
                .Table("TERETNO_ANGAZOVANO")
                .ParentKeyColumn("ID_DEONICE")
                .ChildKeyColumn("REG_OZNAKA")
                .Cascade.All();

            HasMany(x => x.RadMasAng)
             .KeyColumn("ID_DEONICE").Cascade.All()
             .Inverse()
             .LazyLoad();

            HasManyToMany(x => x.RadneMasine)
                .Table("RADMAS_ANGAZOVANA")
                .ParentKeyColumn("ID_DEONICE")
                .ChildKeyColumn("REG_OZNAKA")
                .Cascade.All();
        }

    }
}
