using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class DuziView
    {
        public int IdDuzenja { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Putnicko { get; set; }
        public string Nadzornik { get; set; }

        public DuziView(Duzi d)
        {
            this.IdDuzenja = d.IdDuzenja;
            this.DatumOd = d.DatumOd;
            this.DatumDo = d.DatumDo;
            this.Putnicko = d.PutnickaVozila.RegOznaka;
            this.Nadzornik = d.Nadzornici.Ime;
        }
    }
}
