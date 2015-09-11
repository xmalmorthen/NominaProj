using Dashboard.Models.webApi;
using Dashboard.Models.webApi.strunctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dashboard.Controllers.webApi
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