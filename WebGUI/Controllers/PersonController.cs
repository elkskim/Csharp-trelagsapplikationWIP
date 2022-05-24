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
            if (person == null)
            {
                return View("PersonCreation", null);
            }
            else if (ModelState.IsValid)
            {
                PersonBLL personBLL = new PersonBLL();
                personBLL.AddPerson(person);
                return View("PersonCreation");
            } else
            {
                return View("PersonCreation");
            }
        }
        
        public ActionResult RemovePerson(int id)
        {
            PersonBLL personBLL = new PersonBLL();
            personBLL.RemovePerson(id);
            return View("PersonCreation");
        }

        public ActionResult EditPerson(Person person)
        {
            PersonBLL personBLL = new PersonBLL();
            personBLL.EditPerson(person);
            return View("PersonCreation");
        }

        public ActionResult GetPerson(int id)
        {
            PersonBLL personBLL = new PersonBLL();
            return View("PersonCreation", personBLL.getPerson(id));
            
        }

    }
}