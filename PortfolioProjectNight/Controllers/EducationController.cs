using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult EducationList()
        {
            return View();
        }

        public ActionResult CreateEducation()
        {
            //  @RenderBody()  layout değil content kısımları için kullanılır.
            return View();
        }


    }
}