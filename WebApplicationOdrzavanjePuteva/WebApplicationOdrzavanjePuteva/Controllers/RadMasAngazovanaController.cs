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
    public class RadMasAngazovanaController : ApiController
    {
        public IList<RadMasAngazovanaView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<RadMasAngazovanaView> lista = dp.GetRadMasAngazovanja();

            return lista;
        }

        // GET api/radmasangazovana/5
        public RadMasAngazovanaView Get(int id)
        {
            DataProvider dp = new DataProvider();

            RadMasAngazovanaView rma = dp.GetRadMasAngazovana(id);

            return rma;
        }

        /*
        // POST api/radmasangazovana
        public int Post([FromBody]RadMasAngazovana value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddRadMasAngazovana(value);
        }
        */
        // PUT api/radmasangazovana/5
        public int Put(int id, [FromBody]RadMasAngazovana value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateRadMasAngazovana(id, value);
        }
        
        // DELETE api/radmasangazovana/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveRadMasAngazovana(id);
        }
    }
}
