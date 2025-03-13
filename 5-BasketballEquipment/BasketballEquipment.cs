namespace _5_BasketballEquipment
{
    internal class BasketballEquipment
    {
        static void Main(string[] args)
        {
            int yearFee = int.Parse(Console.ReadLine());

            double shoesPrice = yearFee * 0.60;
            double clothesPrice = shoesPrice * 0.80;
            double ballPrice = clothesPrice / 4;
            double accessoriesPrice = ballPrice / 5;

            double total = yearFee + shoesPrice + clothesPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(total);
        }
    }
}