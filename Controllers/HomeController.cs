using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IubShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ContactAction()
        {
            string name = HttpContext.Request.Form["name"];
            string email = HttpContext.Request.Form["email"];
            string subject = HttpContext.Request.Form["subject"];
            string message = HttpContext.Request.Form["message"];
            return new ContentResult() { Content = string.Format("Dados recebidos com sucesso! Nome: {0} E-mail: {1} Assunto: {2} Mensagem: {3}", name, email, subject, message), ContentType = "text/html" };
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}