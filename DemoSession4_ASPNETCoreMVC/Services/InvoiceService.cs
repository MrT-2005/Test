using DemoSession4_ASPNETCoreMVC.Models;

namespace DemoSession4_ASPNETCoreMVC.Services
{
    public interface InvoiceService
    {
        public List<Invoice> findAll();

        public Invoice find(int id);

    }
}
