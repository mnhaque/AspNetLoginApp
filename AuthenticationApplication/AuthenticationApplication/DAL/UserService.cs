using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationApplication.Entities;
using AuthenticationApplication.Framework;
using AutoMapper;

namespace AuthenticationApplication.DAL
{
    public class UserService : IUserService
    {
        private DataContext dataContext;
        private IMapper mapper;

        public UserService(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        public Entities.User Login(string userName, string password)
        {
            return dataContext.User.FirstOrDefault(x => x.Email.Equals(userName) && x.Password.Equals(password));
        }

        public async Task<bool> Register(Models.User user)
        {

            if (dataContext.User.Any(x=>x.Email.Equals(user.Email)))
            {
                throw new DuplicatePrimaryKeyException();
            }
            dataContext.User.Add(mapper.Map<User>(user));
            await dataContext.SaveChangesAsync();
            return true;
        }

    }
}
