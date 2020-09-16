using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Putevi.Entiteti;

namespace Putevi.Mapiranja
{
    public class RadnaMasinaMap:SubclassMap<RadnaMasina>
    {
        public RadnaMasinaMap()
        {
            Table("RADNA_MASINA");
            Schema("S16103");

            KeyColumn("REG_OZNAKA");

            Map(x => x.Tip, "TIP");
            Map(x => x.TipPogona, "TIP_POGONA");



        }
    }
}
