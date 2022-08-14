using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession4_ASPNETCoreMVC.Controllers
{
    [Route("demo3")]
    public class Demo3Controller : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("search1")]
        public IActionResult Search1(string keyword)
        {
            Debug.WriteLine("keyword: " + keyword);
            return RedirectToAction("index", "demo3");
        }

        [Route("search2")]
        public IActionResult Search2(double min, double max)
        {
            Debug.WriteLine("min: " + min);
            Debug.WriteLine("max: " + max);
            return RedirectToAction("index", "demo3");
        }
    }
}
