
using AppECM.Contratos;
using AppECM.Model;
using AppECM.Services.Base;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppECM.Services
{
    public class SSOServices : BaseService
    {
        private readonly string url = "/usuario/validarlogin";
        public async Task<Authenticate> LoginUserAsync(Authenticate authenticate)
        {
            object param = new { login = authenticate.User.UserName.Trim(), senha = authenticate.User.Password.Trim() };

            ValidarLogin(authenticate);
            return authenticate;
        }
        public Authenticate LoginUser(Authenticate authenticate)
        {
            ValidarLogin(authenticate);
            return authenticate;

        }

        private static void ValidarLogin(Authenticate authenticate)
        {
            if (authenticate.User.UserName.Trim() == "admin" && authenticate.User.Password.Trim() == "12345")
            {
                authenticate.IsAuthenticated = true;
            }
            else
            {
                authenticate.Message = "Usuario ou Senha Invalidos!";
                authenticate.IsAuthenticated = false;

            }
        }
    }
    public class Acess : IReturnService
    {
        public string Acessar { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public bool acesso { get; set; }

    }
}
