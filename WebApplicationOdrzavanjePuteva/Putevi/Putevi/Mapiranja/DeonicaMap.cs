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

            // primary key
            CompositeId().KeyProperty(x => x.IdDeonice, "ID_DEONICE").KeyReference(x => x.Gradiliste, "ID_GRADILISTA");
            
            // properties
            Map(x => x.KrajnjiGrad, "KRAJNJI_GRAD");
            Map(x => x.PocetniGrad, "POCETNI_GRAD");
            Map(x => x.PocetniKilometar, "POCETNI_KM");
            Map(x => x.ZavrsniKilometar, "ZAVRSNI_KM");
            //References(x=>x.Gradiliste).Column("")
            // Map(x => x.GodProizvodnje, "GOD_PROIZVODNJE");
        }

    }
}
