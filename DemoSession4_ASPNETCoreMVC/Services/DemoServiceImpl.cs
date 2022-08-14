namespace DemoSession4_ASPNETCoreMVC.Services
{
    public class DemoServiceImpl : DemoService
    {
        public string Hello()
        {
            return "Hello World";
        }

        public string Hi(string name)
        {
            return "Hi " + name;
        }
    }
}
