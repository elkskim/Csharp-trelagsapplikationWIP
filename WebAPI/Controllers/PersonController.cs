using BusinessLogic.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        // GET: Person

        [HttpGet]
        public Person GetPerson(int id)
        {
            PersonBLL bll = new PersonBLL();
            return bll.getPerson(id);
        }


    }
}