using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecycleTroop_Database_Interface.Models;

namespace RecycleTroop_Database_Interface.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var client = new Clients() { ID = 123456 };

            return View(client);
        }
    }
}