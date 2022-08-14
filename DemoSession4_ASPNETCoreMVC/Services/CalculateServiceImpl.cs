namespace DemoSession4_ASPNETCoreMVC.Services
{
    public class CalculateServiceImpl : CalculateService
    {
        public double add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double mul(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
