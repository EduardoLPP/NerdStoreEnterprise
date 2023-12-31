﻿using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if(id == 500)
            {
                modelErro.Mensagem = "Deu errado.";
                modelErro.Titulo = "Ocorreu um erro.";
                modelErro.Codigo = id;
            }
            else if(id == 404)
            {
                modelErro.Mensagem = "A página que está procurando não existe! <br />" +
                    "Em caso de dúvidas entrem em contato com o nosso suporte.";
                modelErro.Titulo = "Ops! Página não encontrada.";
                modelErro.Codigo = id;
            }
            else if (id == 403)
            {
                modelErro.Mensagem = "Você não tem permissão para fazer isto.";
                modelErro.Titulo = "Acesso Negado";
                modelErro.Codigo = id;
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelErro);
        }
    }
}