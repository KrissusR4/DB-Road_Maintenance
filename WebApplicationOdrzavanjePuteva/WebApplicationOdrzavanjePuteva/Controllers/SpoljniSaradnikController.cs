using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Putevi;
using Putevi.Entiteti;
using Putevi.DTOs;

namespace WebApplicationOdrzavanjePuteva.Controllers
{
    public class SpoljniSaradnikController : ApiController
    {
        public IList<SpoljniSaradnikView> Get()
        {
            DataProvider dp = new DataProvider();

            IList<SpoljniSaradnikView> saradnici = dp.GetSpoljneSaradnike();

            return saradnici;
        }

        
    }
}
