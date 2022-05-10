using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO.Model;
using BusinessLogic.BLL;

namespace WebGUI.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult GroupCRUD()
        {

            return View();
        }

        [HttpPost]

        public ActionResult AddGroup(Group group)
        {
            GroupBLL groupBLL = new GroupBLL();
            groupBLL.AddGroup(group);
            return View("GroupCRUD");
        }


        
    }
}