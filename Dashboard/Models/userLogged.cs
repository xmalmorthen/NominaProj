using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Models
{
    public static class userLogged
    {
        private static dbContext.dbDataContext db = new dbContext.dbDataContext();

        public static dbContext.paGetUserDataResult getUserData(int id) {
            return db.paGetUserData(id).SingleOrDefault();
        }

    }
}