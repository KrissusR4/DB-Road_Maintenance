using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Radnik
    {
        public virtual int IdRadnik { get; set; }

        public virtual Int64 JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string OcevoIme { get; set; }
        public virtual string Adresa { get; set; }
        public virtual int GodRodj { get; set; }
        public virtual string TipPosla { get; set; }
        public virtual bool JeSef { get; set; }
        public virtual Preduzece Preduzece { get; set; }

        public virtual Radnik Sef { get; set; }
        public virtual IList<Radnik> Podredjeni { get; set; }
        
        public Radnik()
        {
            Podredjeni = new List<Radnik>();
        }

        /*public virtual string FullName
        {
            get { return (Ime +" "+ OcevoIme[0]+". " + Prezime); }
           
        }*/

    }
}
