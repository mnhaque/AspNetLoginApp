using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        [HttpPost]
        public bool Register(User user)
        {
            return false;
        }
        [HttpGet]
        public bool Login(string userName, string pwd)
        {
            return false;
        }
    }
}