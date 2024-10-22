using PortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class StatisticsController : Controller
    {
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();

        public ActionResult Index()
        {
            ViewBag.totalMessageCount = context.Contact.Count();  // 1 tane değer getirmek istediğimiz için controller tarafından view tarafına değer taşıyor onun için kullanıyoruz.
            ViewBag.messageIsReadTrueCount = context.Contact.Where(x=> x.IsRead==true).Count();
            ViewBag.messageIsReadFalseCount = context.Contact.Where(y => y.IsRead == false).Count();
            ViewBag.skillCount = context.Skill.Count();
            ViewBag.skillRateSum = context.Skill.Sum(x => x.Rate);
            ViewBag.skillRateAvg = context.Skill.Average(x => x.Rate);


            var maxRate = context.Skill.Max(x => x.Rate); // skil tablosundaki en yüksek değeri buluyor.
            ViewBag.maxRateSkillName = context.Skill.Where(x => x.Rate == maxRate).Select(y=>y.SkillName).FirstOrDefault(); //komple satırı getirir. Tek değer getirmek istediğimizde FirstOrDefault()'u kullanırız.
            

            //konusu referans olan mesaj sayısını bulalım.
            ViewBag.getMessageCountBySubjectReferances = context.Contact.Where(x => x.Subject == "Referans").Count();

            //konusu referans olan mesajın göndericisinin adını bulalım.
            // index kısmına bunu yaptık.
            // <div class="alert alert-primary" style="background-color:gray">Referans Konulu Mesaj Sayısı:<b>@ViewBag.getMessageCountBySubjectReferances</b></div>

            ViewBag.getMessageCountByEmailContainHAndIsreadTrue = context.Contact.Where(x => x.IsRead == true && x.Email.Contains("h")).Count();


            // Sql de bunu nasıl getiririz.
            //  SkillId   SkillName             Rate
            //   5	        Asp.Net Core	     90
            ViewBag.getSkillNameByRate90 = context.Skill.Where(x =>x.Rate == 90).Select(y => y.SkillName).FirstOrDefault();


            return View();
        }
    }
}
/* 
 1) Yapacağımız projeler 
  
 DbFirst (Tamamlandı)
 CodeFirst
 AspNet Core N tier arc.
 Identity
 Api
 Rapid Api
 Chain of Resp. (Design Pat)
 CQER & Mediator
 Mongo Db
 PostreSQL
 Onion Arc.
 Jwt (Spotify)
 Ajax - Jquery
 SignalR
 Dapper
 Mikroservis
 Redis 
 ElasticSearch
 IdentityModel

 */