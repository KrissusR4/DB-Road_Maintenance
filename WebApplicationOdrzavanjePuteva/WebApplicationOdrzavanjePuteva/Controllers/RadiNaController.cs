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
    public class RadiNaController : ApiController
    {
        public IList<RadiNaView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<RadiNaView> lista = dp.GetRadiNa();

            return lista;
        }

        // GET api/radina/5
        public RadiNaView Get(int id)
        {
            DataProvider dp = new DataProvider();

            RadiNaView rn = dp.GetRadiNa(id);

            return rn;
        }

        /*
        // POST api/radina
        public int Post([FromBody]RadiNa value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddRadiNa(value);
        }
        */

        // PUT api/radina/5
        public int Put(int id, [FromBody]RadiNa value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateRadiNa(id, value);
        }
        
        // DELETE api/radina/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveRadiNa(id);
        }
    }
}
