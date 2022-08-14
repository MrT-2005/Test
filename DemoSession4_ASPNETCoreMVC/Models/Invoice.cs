namespace DemoSession4_ASPNETCoreMVC.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Payment { get; set; }
        public double Total { get; set; }
    }
}
