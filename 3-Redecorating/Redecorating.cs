using System;
class Redecorating { 
    static void Main()
    {    
    double nylonPricePerSquareMeter = 1.50;
    double paintPricePerLiter = 14.50;
    double paintThinnerPricePerLiter = 5.00;
    double bagsTotalPrice = 0.40;

    double nylon = double.Parse(Console.ReadLine());
    double paint = double.Parse(Console.ReadLine());
    double thinner = double.Parse(Console.ReadLine());
    int hoursForWork = int.Parse(Console.ReadLine());

        nylon += 2;
        paint *= 1.1;

        double nylonCost = nylon * nylonPricePerSquareMeter;
        double paintCost = paint * paintPricePerLiter;
        double thinnerCost = thinner * paintThinnerPricePerLiter;

        double totalMaterialsCost = nylonCost + paintCost + thinnerCost + bagsTotalPrice;
        double workPricePerHour = totalMaterialsCost * 0.30;
        double totalWorkCost = hoursForWork * workPricePerHour;

        double grandTotalWithWork = totalMaterialsCost + totalWorkCost;

    Console.WriteLine(grandTotalWithWork);
    }
}