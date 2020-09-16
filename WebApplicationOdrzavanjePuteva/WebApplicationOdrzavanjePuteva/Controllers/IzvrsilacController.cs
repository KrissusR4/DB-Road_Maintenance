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
    public class IzvrsilacController : ApiController
    {
        public IList<IzvrsilacView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<IzvrsilacView> izvrsioci = dp.GetIzvrsioce();

            return izvrsioci;
        }

        // GET api/izvrsilac/5
        public IzvrsilacView Get(int id)
        {
            DataProvider dp = new DataProvider();

            IzvrsilacView izvrsilac = dp.GetIzvrsilac(id);

            return izvrsilac;
        }

        // POST api/izvrsilac
        public int Post([FromBody]Izvrsilac value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddIzvrsilac(value);
        }

        // PUT api/izvrsilac/5
        public int Put(int id, [FromBody]Izvrsilac value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateIzvrsilac(id, value);
        }

        // DELETE api/izvrsilac/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveIzvrsilac(id);
        }
    }
}

