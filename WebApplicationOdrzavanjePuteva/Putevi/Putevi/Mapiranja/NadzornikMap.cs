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
            Table("IZVRSILAC");

            Schema("S16103");

            KeyColumn("ID_RADNIK");

            References(x => x.Preduzece, "ID_PREDUZECA");

            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");

            //HasMany(x => x.SpoljniSaradnici).KeyColumn("BROJ_UGOVORA_O_DELU").KeyColumn("ID_NADZORNIKA").Inverse().Table("");


            HasMany(x => x.PutnickaVozila)
            .Cascade.All().KeyColumn("ID_RADNIK")
            .Inverse()
            .Table("DUZI");
        }
    }
}
