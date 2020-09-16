using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class RadnikMap:ClassMap<Radnik>
    {
        public RadnikMap()
        {
            Table("RADNIK");

            Schema("S16103");

            Id(x => x.IdRadnik, "ID_RADNIK").GeneratedBy.TriggerIdentity();

            // properties
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.OcevoIme, "OCEVO_IME");
            Map(x => x.GodRodj, "GODINA_RODJ");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.TipPosla, "TIP_POSLA");
            Map(x => x.JeSef, "JE_SEF");
            References(x => x.Preduzece, "ID_PREDUZECE");

            References(x => x.Sef).Column("ID_NADREDJENI");

            HasMany(x => x.Podredjeni)
             .KeyColumn("ID_Nadredjeni").Cascade.All()
             .Inverse().LazyLoad();




        }
    }
}
