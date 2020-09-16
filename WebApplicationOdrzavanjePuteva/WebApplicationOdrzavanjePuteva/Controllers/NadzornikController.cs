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
    public class NadzornikController : ApiController
    {
        public IList<NadzornikView> Get()
        {
            Putevi.DataProvider dp = new DataProvider();

            IList<NadzornikView> nadzornici = dp.GetNadzornike();
            
            return nadzornici;
        }

        // GET api/nadzornik/5
        public NadzornikView Get(int id)
        {
            DataProvider dp = new DataProvider();

            NadzornikView nadzornik = dp.GetNadzornik(id);

            return nadzornik;
        }

        // POST api/nadzornik
        public int Post([FromBody]Nadzornik value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddNadzornik(value);
        }

        // PUT api/nadzornik/5
        public int Put(int id, [FromBody]Nadzornik value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateNadzornik(id, value);
        }

        // DELETE api/nadzornik/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveNadzornik(id);
        }
    }
}

