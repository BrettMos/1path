using shanuMVCUserRoles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


/*namespace shanuMVCUserRoles.Controllers
{
    public class ClientApplicationController : Controller
    {
        // GET: ClientApplication
        public ActionResult Index()
        {
            ClientApplicationEntity DB = new Models.ClientApplicationEntity();
            Client_Application ClientApp = DB.Client_Application;
            return View(ClientAppList);
        }

    }
}*/
namespace shanuMVCUserRoles.Controllers
{
    public class ClientApplicationController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Client_Application obj)

        {
            if (ModelState.IsValid)
            {
                Client_Application db = new Client_Application();
            }
            return View(obj);
        }
    }
}