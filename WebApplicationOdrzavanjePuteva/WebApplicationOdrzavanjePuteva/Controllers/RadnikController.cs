using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Putevi;
using Putevi.Entiteti;
using Putevi.DTOs;

namespace OdrzavanjePutevaWEB.Controllers
{
    public class RadnikController : ApiController
    {
        public IList<RadnikView> Get()
        {
            Putevi.DataProvider dp = new DataProvider();

            IList<RadnikView> radnici = dp.GetRadnike();
            
            return radnici;
        }

        // GET api/radnik/5
        public RadnikView Get(int id)
        {
            DataProvider dp = new DataProvider();

            RadnikView radnik = dp.GetRadnik(id);

            return radnik;
        }

        // POST api/radnik
        public int Post([FromBody]Radnik value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddRadnik(value);
        }

        // PUT api/radnik/5
        public int Put(int id, [FromBody]Radnik value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateRadnik(id, value);
        }

        // DELETE api/radnik/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveRadnik(id);
        }
    }
}
