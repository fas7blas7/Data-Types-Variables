namespace _4_FoodDelivery
{
    internal class FoodDelivery
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double vegetarianMenuPrice = 8.15;
            double deliveryPrice = 2.50;

            double total = chickenMenu * chickenMenuPrice + fishMenu * fishMenuPrice + vegetarianMenu * vegetarianMenuPrice;

            double desertPrice = total * 0.20;

            double grandTotal = total + desertPrice + deliveryPrice;

            Console.WriteLine(grandTotal);
        }
    }
}
