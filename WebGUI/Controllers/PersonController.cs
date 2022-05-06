using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.BLL;
using DTO.Model;

namespace WebGUI.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult PersonCreation()
        {


            return View();
        }

        [HttpPost]

        public ActionResult AddPerson(Person person)
        {
            PersonBLL personBLL = new PersonBLL();
            personBLL.AddPerson(person);
            return View("PersonCreation");
        }

    }
}