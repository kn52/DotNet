using System.Web.Mvc;

namespace StudentMgmt.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id = 1, string name = "none")
        {
            var n = id + " " + "Akhil Birdi";
            return n;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}