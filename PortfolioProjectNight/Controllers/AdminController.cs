using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class AdminController : Controller
    {
        // Notlar 
        // () parantez varsa metod 
        // public int sınav1 {get; set;} property
        // Field class a yazıldığı zaman (public kısmının üstüne yazdığımızda)
        // Variable kısmı da ; 
        // public ActionResult Index()
        // {
        //     string yas1;
        //     return View();
        //      yas1 dediğimiz kısım variable kısmıdır.
        // }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        
    }
}