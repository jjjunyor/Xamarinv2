using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using AppECM.Services.Base;
using AppECM.Model;

namespace AppECM.Services
{
    public class UserServices : BaseService
    {
        private readonly string url = "/usuario/";
        public async Task<User> GetUserAsync(User user)
        {
            Users userAcess = new Users() { login="Jose de Anchieta"};
             user = new User() { Id = 1, Name = "Jose de Anchieta", Password = "12345", UserName = "admin" };
            return user;
        }

    }
}
