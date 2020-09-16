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
    public class RadnaMasinaController : ApiController
    {
        public IList<RadnaMasinaView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<RadnaMasinaView> vozila = dp.GetRadneMasine();

            return vozila;
        }

        // GET api/radnamasina/5
        public RadnaMasinaView Get(string id)
        {
            DataProvider dp = new DataProvider();

            RadnaMasinaView vozilo = dp.GetRadMasina(id);

            return vozilo;
        }

        // POST api/radnamasina
        public int Post([FromBody]RadnaMasina value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddRadMasina(value);
        }

        // PUT api/radnamasina/5
        public int Put(string id, [FromBody]RadnaMasina value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateRadnaMasina(id, value);
        }

        // DELETE api/radnamasina/5
        public int Delete(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveRadnaMasina(id);
        }
    }
}
