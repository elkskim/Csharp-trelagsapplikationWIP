using BusinessLogic.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        // GET: Person
        public Person GetPerson(int id)
        {
            PersonBLL bll = new PersonBLL();
            return bll.getPerson(id);
        }


    }
}