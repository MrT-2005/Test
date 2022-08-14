using DemoSession4_ASPNETCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession4_ASPNETCoreMVC.Controllers
{
    [Route("invoice")]
    public class InvoiceController : Controller
    {
        private InvoiceService invoiceService;

        public InvoiceController(InvoiceService _invoiceService)
        {
            invoiceService = _invoiceService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.invoices = invoiceService.findAll();
            return View();
        }

        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.invoice = invoiceService.find(id);
            return View();
        }
    }
}
