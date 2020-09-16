using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class PreduzeceMap:ClassMap<Putevi.Entiteti.Preduzece>
    {
        public PreduzeceMap()
        {
            Table("PREDUZECE");

            Schema("S16103");

            Id(x => x.IdPreduzeca ,"ID_PREDUZECE").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");

           HasMany(x => x.Vozila).KeyColumn("ID_PREDUZECE").Cascade.All().Inverse();
             

            HasMany(x => x.Radnici)
             .KeyColumn("ID_PREDUZECE").Cascade.All()
             .Inverse();


            HasMany(x => x.Gradilista)
             .KeyColumn("ID_PREDUZECE").Cascade.All()
             .Inverse();
             

        }
    }
}
