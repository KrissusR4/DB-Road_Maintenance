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
    public class UpravljaController : ApiController
    {
        public IList<UpravljaView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<UpravljaView> lista = dp.GetUpravljanja();

            return lista;
        }

        // GET api/upravlja/5
        public UpravljaView Get(int id)
        {
            DataProvider dp = new DataProvider();

            UpravljaView ta = dp.GetUpravlja(id);

            return ta;
        }
        /*
        // POST api/upravlja
        public int Post([FromBody]Upravlja value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddUpravlja(value);
        }
        */
        // PUT api/upravlja/5
        public int Put(int id, [FromBody]Upravlja value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateUpravlja(id, value);
        }
        
        // DELETE api/upravlja/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveUpravlja(id);
        }
    }
}
