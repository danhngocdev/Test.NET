using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using TestWebApi.WebApp.Models;

namespace TestWebApi.WebApp.Controllers
{


    public class LoginController : ApiController
    {
        private TESTONLINEEntities db = new TESTONLINEEntities();


        
        [HttpPost]
        public Employee Login(Employee e)
        {
            var res = db.Employees.FirstOrDefault(s => s.username == e.username && s.passwords == e.passwords);
            return res;
            
        }
    }
}
