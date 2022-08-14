using DemoSession4_ASPNETCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession4_ASPNETCoreMVC.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private DemoService demoService;
        private CalculateService calculateService;

        // Injection Constructor
        public DemoController(DemoService _demoService, CalculateService _calculateService)
        {
            this.demoService = _demoService;
            calculateService = _calculateService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.result1 = demoService.Hello();
            ViewBag.result2 = demoService.Hi("ABC");
            ViewBag.result3 = calculateService.add(1, 2);
            ViewBag.result4 = calculateService.mul(10, 3);
            return View();
        }
    }
}
