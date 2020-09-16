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
    public class PutnickoController : ApiController
    {
        public IList<PutnickoView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<PutnickoView> vozila = dp.GetPutnicka();

            return vozila;
        }

        // GET api/putnicko/5
        public PutnickoView Get(string id)
        {
            DataProvider dp = new DataProvider();

            PutnickoView vozilo = dp.GetPutnicko(id);

            return vozilo;
        }

        // POST api/putnicko
        public int Post([FromBody]Putnicko value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddPutnicko(value);
        }

        // PUT api/putnicko/5
        public int Put(string id, [FromBody]Putnicko value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdatePutnicko(id, value);
        }

        // DELETE api/putnicko/5
        public int Delete(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemovePutnicko(id);
        }
    }
}
