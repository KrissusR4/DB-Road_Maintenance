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
            Map(x => x.OcevoIme, "OCEVO_IME");
            Map(x => x.GodRodj, "GODINA_RODJ");
            Map(x => x.Adresa, "ADRESA");

            References(x => x.Preduzece, "ID_PREDUZECE");
            References(x => x.Sef, "ID_NADREDJENI");


        }
    }
}
