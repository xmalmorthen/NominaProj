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
    public class dashboardController : ApiController
    {
        // GET apiV1/AYIID3
        [HttpGet]
        public IEnumerable<paNewMessagesByIdUserResult> getNewMessagesByIdUser(int id)
        {
            return get.getNewMessagesByIdUser(id);
        }
        
    }
}