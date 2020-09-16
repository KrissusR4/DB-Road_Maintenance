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
    public class TeretnoController : ApiController
    {
        public IList<TeretnoView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<TeretnoView> vozila = dp.GetTeretna();

            return vozila;
        }

        // GET api/teretno/5
        public TeretnoView Get(string id)
        {
            DataProvider dp = new DataProvider();

            TeretnoView vozilo = dp.GetTeretno(id);

            return vozilo;
        }

        // POST api/teretno
        public int Post([FromBody]Teretno value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddTeretno(value);
        }

        // PUT api/teretno/5
        public int Put(string id, [FromBody]Teretno value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateTeretno(id, value);
        }

        // DELETE api/teretno/5
        public int Delete(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveTeretno(id);
        }
    }
}
