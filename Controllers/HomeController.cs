using meetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();
            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 30, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}