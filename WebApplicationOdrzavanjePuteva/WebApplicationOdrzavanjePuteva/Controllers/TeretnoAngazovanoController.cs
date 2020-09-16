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
    public class TeretnoAngazovanoController : ApiController
    {
        public IList<TeretnoAngazovanoView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<TeretnoAngazovanoView> lista = dp.GetTeretnoAngazovanja();

            return lista;
        }
        
        // GET api/teretnoangazovano/5
        public TeretnoAngazovanoView Get(int id)
        {
            DataProvider dp = new DataProvider();

            TeretnoAngazovanoView ta = dp.GetTeretnoAngazovano(id);

            return ta;
        }

        /*
        // POST api/teretnoangazovano
        public int Post([FromBody]TeretnoAngazovano value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddTeretnoAngazovano(value);
        }
        */

        // PUT api/teretnoangazovano/5
        public int Put(int id, [FromBody]TeretnoAngazovano value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateTeretnoAngazovano(id, value);
        }

        // DELETE api/teretnoangazovano/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveTeretnoAngazovano(id);
        }
    }
}
