using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace GymSoftApplication.Controllers
{
    public class TestConnectionController : Controller
    {
        // GET: TestConnection
        public ActionResult Index()
        {
            try
            {
                  
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }
    }
}