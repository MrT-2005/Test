namespace DemoSession4_ASPNETCoreMVC.Services
{
    public class RectangleServiceImpl : RectangleService
    {
        private CalculateService calculateService;

        public RectangleServiceImpl(CalculateService _calculateService)
        {
            calculateService = _calculateService;
        }

        public double area(double a, double b)
        {
            return calculateService.mul(a, b);
        }

        public double perimeter(double a, double b)
        {
            return calculateService.mul(calculateService.add(a, b), 2);
        }
    }
}
