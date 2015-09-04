using GetPostModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetPostModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {   
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PostGet()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Henrique Santana",
                Senha = "123"
            };
            return View(pessoa);
        } 

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            /*ViewBag.PessoaId = pessoa.PessoaId;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Senha = pessoa.Senha;*/

            return View(pessoa);
        }
    }
}