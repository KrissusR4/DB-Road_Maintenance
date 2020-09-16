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

            KeyColumn("ID_VOZILA");

            Map(x => x.BrojMesta, "BROJ_MESTA");
            


        }
    }
}
