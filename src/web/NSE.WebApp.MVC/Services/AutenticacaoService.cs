using NSE.WebApp.MVC.Interfaces.Services;
using NSE.WebApp.MVC.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Services
{
    public class AutenticacaoService : Service, IAutenticacaoService
    {
        private readonly HttpClient _httpClient;

        public AutenticacaoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UsuarioRespostaLogin> Login(UsuarioLoginViewModel usuario)
        {
            var loginContent = new StringContent(
                JsonSerializer.Serialize(usuario),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync("https://localhost:44383/api/identidade/autenticar", loginContent);

            if (!TratarErrosResponse(response))
                return new UsuarioRespostaLogin
                {
                    ResponseResult = JsonSerializer.Deserialize<ResponseResult>(await response.Content.ReadAsStringAsync(), ObtenhaOptionsDoJsonSerializer())
                };

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync(), ObtenhaOptionsDoJsonSerializer());
        }

        public async Task<UsuarioRespostaLogin> Registro(UsuarioRegistroViewModel usuario)
        {
            var registroContent = new StringContent(
                JsonSerializer.Serialize(usuario), 
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync("https://localhost:44383/api/identidade/nova-conta", registroContent);

            if (!TratarErrosResponse(response))
                return new UsuarioRespostaLogin
                {
                    ResponseResult = JsonSerializer.Deserialize<ResponseResult>(await response.Content.ReadAsStringAsync(), ObtenhaOptionsDoJsonSerializer())
                };

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync(), ObtenhaOptionsDoJsonSerializer());
        }

        private JsonSerializerOptions ObtenhaOptionsDoJsonSerializer()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return options;
        }
    }
}
