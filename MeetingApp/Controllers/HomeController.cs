using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{   
        public class HomeController: Controller
        {
  
            public IActionResult Index()
            {
                int saat = DateTime.Now.Hour;

                ViewData["Selamlama"] = saat > 12 ? "İyi günler":"Günaydın";
                //ViewData["UserName"] = "Nisa";
                int UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();

                var meetingInfo = new MeetingInfo(){
                    Id = 1, 
                    Location = "İstanbul, ABC Kongre Merkezi",
                    Date = new DateTime(2025, 05, 26, 13, 0, 00),
                    NumberOfPeople = UserCount
                };
                return View(meetingInfo);
            }
        }
}