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
    public class DeonicaController : ApiController
    {
        public IList<DeonicaView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<DeonicaView> deonice = dp.GetDeonice();

            return deonice;
        }

        // GET api/deonica/5
        public DeonicaView Get(int id)
        {
            DataProvider dp = new DataProvider();

            DeonicaView d =dp.GetDeonica(id);

            return d;
        }

        // POST api/deonica
        public int Post([FromBody]Deonica value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddDeonica(value);
        }

        // PUT api/deonica/5
        public int Put(int id, [FromBody]Deonica value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateDeonica(id, value);
        }

        // DELETE api/deonica/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveDeonica(id);
        }
    }
}
