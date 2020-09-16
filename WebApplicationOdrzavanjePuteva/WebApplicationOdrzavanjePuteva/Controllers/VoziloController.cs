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
    public class VoziloController : ApiController
    {
        public IList<VoziloView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<VoziloView> vozila = dp.GetVozila();

            return vozila;
        }

        // GET api/vozilo/5
        public VoziloView Get(string id)
        {
            DataProvider dp = new DataProvider();

            VoziloView vozilo = dp.GetVozilo(id);

            return vozilo;
        }

        // POST api/vozilo
        public int Post([FromBody]Vozilo value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddVozilo(value);
        }

        // PUT api/vozilo/5
        public int Put(string id, [FromBody]Vozilo value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateVozilo(id, value);
        }

        // DELETE api/vozilo/5
        public int Delete(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveVozilo(id);
        }
    }
}
