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
    public class GradilisteController : ApiController
    {
        public IList<GradilisteView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<GradilisteView> gradilista = dp.GetGradilista();

            return gradilista;
        }

        // GET api/gradiliste/5
        public GradilisteView Get(int id)
        {
            DataProvider dp = new DataProvider();

            GradilisteView gradiliste = dp.GetGradiliste(id);

            return gradiliste;
        }

        // POST api/gradiliste
        public int Post([FromBody]Gradiliste value)
        {
            DataProvider dp = new DataProvider();
            return dp.AddGradiliste(value);
        }

        // PUT api/gradiliste/5
        public int Put(int id, [FromBody]Gradiliste value)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateGradiliste(id, value);
        }

        // DELETE api/gradiliste/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.RemoveGradiliste(id);
        }
    }
}
