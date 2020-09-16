using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iesi.Collections;

namespace Putevi.Entiteti
{
    public class SpoljniSaradnik
    {
        public virtual int BrUgovoraODelu { get; set; }
        public virtual Nadzornik Nadzornik {get; set;}

        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

           if (obj.GetType() != typeof(SpoljniSaradnik))
                return false;

            SpoljniSaradnik recievedObject = (SpoljniSaradnik)obj;

            if ((this.BrUgovoraODelu == recievedObject.BrUgovoraODelu) && (Nadzornik== recievedObject.Nadzornik))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
                return base.GetHashCode(); 
        }
        
    }
}
