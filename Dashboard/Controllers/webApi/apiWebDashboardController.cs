using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dashboard.Models;
using Dashboard.Models.dbContext;
using Dashboard.Models.webApi;

namespace Dashboard.Controllers.webApi
{
    public class apiWebDashboardController : ApiController
    {
        // GET apiV1/AYIID3
        [HttpGet]
        public IEnumerable<paNewMessagesByIdUserResult> getNewMessagesByIdUser(int id)
        {
            return get.getNewMessagesByIdUser(id);
        }
        
    }
}