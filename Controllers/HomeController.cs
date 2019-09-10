using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IubShop.Libraries.Email;
using IubShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IubShop.Database;

namespace IubShop.Controllers
{
    public class HomeController : Controller
    {
        private IubShopContext _db;
        public HomeController(IubShopContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]Newsletter newsletter)
        {
            if(ModelState.IsValid)
            {
                _db.Newsletter.Add(newsletter);
                _db.SaveChanges();

                TempData["success"] = "Obrigado por ter assinado nossa newsletter. A partir de agora você receberá ofertas e promoções em seu email!";

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ContactAction()
        {
            try
            {
                Contact contact = new Contact();

                contact.Name = HttpContext.Request.Form["name"];
                contact.Email = HttpContext.Request.Form["email"];
                contact.Subject = HttpContext.Request.Form["subject"];
                contact.Message = HttpContext.Request.Form["message"];

                var messageList = new List<ValidationResult>();
                var context = new ValidationContext(contact);
                bool isValid = Validator.TryValidateObject(contact, context, messageList, true);

                if (isValid)
                {
                    ContactEmail.SenderContactEmail(contact);
                    //ViewData["success"] = "Mensagem de contato enviada com sucesso";

                    return Ok(new { status = "success", mensagem = "Mensagem de contato enviada com sucesso" }); //Serializar esse Obj Anonimo em JSON

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var _text in messageList)
                    {
                        sb.Append(_text.ErrorMessage);
                    }

                    //ViewData["error"] = sb.ToString();

                    return Ok(new { status = "error", mensagem = sb.ToString() });
                }

            }
            catch (Exception e)
            {
                //ViewData["error"] = "Oooppss houve um erro, tente novamente mais tarde!";

                return Ok(new { status = "error", mensagem = "Oooppss houve um erro, tente novamente mais tarde!" });
                //TODO - Implementar Log
            }

            //return View("Contact");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Client client)
        {
            if (ModelState.IsValid)
            {
                _db.Add(client);
                _db.SaveChanges();

                TempData["success"] = "Cadastro realizado com sucesso!";

                //TODO - Implementar redirecionamentos diferentes (Painel, carrinho de compras, etc).
                return RedirectToAction(nameof(Login));
            }
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}