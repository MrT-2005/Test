using DemoSession4_ASPNETCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession4_ASPNETCoreMVC.Controllers
{
    [Route("demo2")]
    public class Demo2Controller : Controller
    {
        private DemoService demoService;

        public Demo2Controller(DemoService _demoService)
        {
            this.demoService = _demoService;
        }

        [Route("index")]
        [Route("")]        
        public IActionResult Index()
        {
            ViewBag.result1 = demoService.Hello();
            ViewBag.result2 = demoService.Hi("ABC");
            return View();
        }
    }
}
