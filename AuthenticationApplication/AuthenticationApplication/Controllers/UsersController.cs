namespace AuthenticationApplication.Controllers
{
    using System.Threading.Tasks;
    using AuthenticationApplication.DAL;
    using AuthenticationApplication.Filteres;
    using AuthenticationApplication.Models;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("api/Users")]
    [ExceptionFilter]
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpPost]
        [ExceptionFilter]
        [Route("Register")]
        public async Task<bool> Register([FromBody]User user)
        {
            return await this.userService.Register(user);
        }

        [HttpGet]
        [Route("Login")]
        [ExceptionFilter]
        public User Login(string userName, string pwd)
        {
            User response = null;
            var user = this.userService.Login(userName, pwd);
            if (user != null)
            {
                return mapper.Map<User>(user);
            }
            return response;
        }
    }
}