using DemoSession4_ASPNETCoreMVC.Models;

namespace DemoSession4_ASPNETCoreMVC.Services
{
    public class InvoiceServiceImpl : InvoiceService
    {

        public Invoice find(int id)
        {
            return findAll().SingleOrDefault(p => p.Id == id);
        }

        public List<Invoice> findAll()
        {
            return new List<Invoice> { 
                
            };
        }
    }
}
