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
    public class PreduzeceController : ApiController
    {
        public IList<PreduzeceView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<PreduzeceView> preduzeca = dp.GetPreduzeca();

            return preduzeca;
        }

        // GET api/preduzece/5
        public PreduzeceView Get(int id)
        {
            DataProvider dp = new DataProvider();

            PreduzeceView preduzece = dp.GetPreduzece(id);

            return preduzece ;
        }

        // POST api/preduzece
        public int Post([FromBody]Preduzece value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddPreduzece(value);
        }

        // PUT api/preduzece/5
        public int Put(int id, [FromBody]Preduzece value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdatePreduzece(id, value);
        }

        // DELETE api/preduzece/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemovePreduzece(id);
        }
    }
}
