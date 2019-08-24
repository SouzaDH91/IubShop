using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IubShop.Libraries.Email;
using IubShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;

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