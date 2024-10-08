using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class CategoryController : Controller
    {
        
        // Sınıfın içinde yapılan yapılar field'dır.
        public ActionResult CategoryList() // parantez varsa metod
        {
            // metodun içinde yapılan yapılar variable'dır.(değişkendir.)
            return View();
        }

        public ActionResult CreateCategory()
        {
            return View();
        }
    }
}