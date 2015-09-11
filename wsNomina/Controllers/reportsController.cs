using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wsNomina.Models;
using wsNomina.Models.dbProviders;

namespace wsNomina.Controllers
{
    public class reportsController : ApiController
    {
        // GET apiV1/AYIID3
        [HttpGet]
        public AYIID3_Model AYIID3()
        {
            return get.AYIID3();
        }

        // GET apiV1/AYIID3
        [HttpGet]
        public AYIID4_Model AYIID4()
        {
            return get.AYIID4();            
        }

    }
}