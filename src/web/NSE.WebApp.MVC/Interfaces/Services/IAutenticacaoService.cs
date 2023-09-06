using NSE.WebApp.MVC.Models;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Interfaces.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLoginViewModel usuario);
        Task<UsuarioRespostaLogin> Registro(UsuarioRegistroViewModel usuario);
    }
}
