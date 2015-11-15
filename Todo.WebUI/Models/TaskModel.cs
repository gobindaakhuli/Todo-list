using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Todo.WebUI.Models
{
    public class TaskModel : Controller
    {
        //
        // GET: /TaskModel/

        public ActionResult Index()
        {
            return View();
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
