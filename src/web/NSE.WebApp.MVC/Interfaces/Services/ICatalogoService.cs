using NSE.WebApp.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Intefaces
{
    public interface ICatalogoService
    {
        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
        Task<ProdutoViewModel> ObterPorId(Guid id);
    }
}
