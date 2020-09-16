﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putevi.Entiteti
{
    public class Vozilo
    {
        public virtual string RegOznaka { get; set; }
        public virtual string Gorivo { get; set; }
        public virtual string Boja { get; set; }
        public virtual int ZapreminaMotora { get; set; }
        public virtual Preduzece Preduzece { get; set; }
        public virtual IList<Upravlja> Izvrsioci { get; set; }

        public Vozilo()
        {
            Izvrsioci = new List<Upravlja>();
        }

    }
}