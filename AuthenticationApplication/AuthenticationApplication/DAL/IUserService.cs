using AuthenticationApplication.Models;
using System.Threading.Tasks;

namespace AuthenticationApplication.DAL
{
    public interface IUserService
    {
        Task<bool> Register(User user);
        Entities.User Login(string userName, string password);
    }
}