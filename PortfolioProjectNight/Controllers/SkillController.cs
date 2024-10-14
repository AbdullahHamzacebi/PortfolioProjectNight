using PortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult SkillList()
        {
            var values = context.Skill.ToList();
            return View(values);
        }

        [HttpGet] // [] Attribute 
        public ActionResult CreateSkill()
        {
            return View();
        }

        /* 
         
         Bir Metodun aynı isimle birden fazla kez kullanılmasına overload deniyor.
         İsim aynı olduğu zaman hata veriyor ve hatayı gidermek için metodun içini dolduruyoruz.
         
         public ActionResult CreateSkill()
        {
            return View();
        }
        Bu kısım sayfa yüklenince


          public ActionResult CreateSkill(Skill skill)  
        {

            return View();
        }
        Bu kısım da sayfa tıklanınca
        
         
         overload'a yönelik örnek;
         int topla(int s1, int s2)
        {
            return s1+ s2;
        }

        int topla(int s1, int s2, int s3) 
        {
           return s1+ s2+ s3;
        }

        Kullanıcı 2 sayı girerse yukardaki 3 sayı girerse alttaki kısım çalışır ve  Bir Metodun aynı isimle birden fazla kez kullanılmasına overload deniyor.

         */

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)  
        {
            context.Skill.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList"); 
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skill.Find(id);
            context.Skill.Remove(value); 
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]

        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skill.Find(id);
            return View(value); 
        }
    }
}