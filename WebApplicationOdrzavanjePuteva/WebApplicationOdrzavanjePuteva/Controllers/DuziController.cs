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
    public class DuziController : ApiController
    {
        public IList<DuziView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<DuziView> duzenja = dp.GetDuzenja();

            return duzenja;
        }

        // GET api/duzi/5
        public DuziView Get(int id)
        {
            DataProvider dp = new DataProvider();

            DuziView duzi = dp.GetDuzi(id);

            return duzi;
        }

        // POST api/duzi
       /* public int Post([FromBody]Duzi value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddDuzi(value);
        }*/

        // PUT api/duzi/5
        public int Put(int id, [FromBody]Duzi value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateDuzi(id, value);
        }

        // DELETE api/duzi/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveDuzi(id);
        }
    }
}
