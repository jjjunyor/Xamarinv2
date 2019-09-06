using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using AppECM.Services.Base;
using AppECM.Model;
using AppECM.Helps;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using FormsToolkit;

namespace AppECM.Services
{
    public class PedidoService : BaseService
    {

    
        public async Task<Moedas> GetMoedaAsync()
        {
            var moedas = new Moedas();
            using (var client = new HttpClient())
            {
                var uri = ApiKeys._urlBancoDoBrasilRest + string.Format("/odata/Moedas?$top=100&$format=json");
 
                var response = client.GetAsync(uri).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var objJSON = response.Content.ReadAsStringAsync().Result;
                    var str = "{" + objJSON.Substring(103, objJSON.Length - 103);
                    moedas = JsonConvert.DeserializeObject<Moedas>(str);

                }
            }
            return moedas;
        }

    }
}
