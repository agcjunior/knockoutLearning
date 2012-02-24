using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnocoutLearning.Models;

namespace KnocoutLearning.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // Action para salvar os dados de uma pessoa recebido da view em Json
        public JsonResult Save(Person person)
        {
            var message = string.Format("Registro gravado {0} {1}", person.FirstName, person.LastName);
            return Json(new { message });
        }

    }
}
