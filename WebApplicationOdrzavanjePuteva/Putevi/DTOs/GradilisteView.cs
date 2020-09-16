using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;

namespace Putevi.DTOs
{
    public class GradilisteView
    {
        public int IdGradilista { get; set; }
        public string Tip { get; set; }
        //public string Preduzece { get; set; }
        public int BrojDeonica { get; set; }

        public GradilisteView(Gradiliste g)
        {
            this.IdGradilista = g.IdGradilista;
            this.Tip = g.Tip;
            //Preduzece = g.Preduzece.Naziv;
            this.BrojDeonica = g.Deonice.Count;
        }
    }
}
