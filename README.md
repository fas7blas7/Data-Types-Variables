# 📌 Coding Tasks

## 📝 Overview
This repository contains a collection of simple coding exercises written in C#. Each task is numbered and includes an icon for better readability.

---

### 1️⃣ Reverse Three Numbers 🔄
```csharp
// Read three numbers from the console and print them in reverse order

double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
double thirdNumber = double.Parse(Console.ReadLine());

Console.WriteLine(thirdNumber);
Console.WriteLine(secondNumber);
Console.WriteLine(firstNumber);
```

---

### 2️⃣ Convert Centuries to Minutes ⏳
```csharp
// Convert centuries to years, days, hours, and minutes

int centuries = int.Parse(Console.ReadLine());
int years = centuries * 100;
int days = (int)(years * 365.2422);
int hours = days * 24;
int minutes = hours * 60;

int resultInMinutes = centuries * 100 * 365 * 24 * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
```

---

### 3️⃣ Redecorating a Room 🎨
```csharp
// Calculate the total cost for redecorating a room

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
```

---

### 4️⃣ Food Delivery 🍽️
```csharp
// Calculate the total cost for a food delivery order

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
```

---

### 5️⃣ Basketball Equipment 🏀
```csharp
// Calculate the total cost of basketball equipment based on the yearly training fee

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
```

---

### 6️⃣ Aquarium 🐠
```csharp
// Calculate the total liters of water needed for an aquarium after accounting for occupied space

namespace _6_Aquarium
{
    internal class Aquarium
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double totalLiters = volume * 0.001;
            double percentageDecimal = percentage * 0.01;
            double totalLitersNeeded = totalLiters * (1 - percentageDecimal);
            Console.WriteLine($"{totalLitersNeeded:F2}");
        }
    }
}
```

---

### 🚀 How to Run
1. Clone the repository:  
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
2. Navigate to the project folder.
3. Compile and run each script in a C# environment.
