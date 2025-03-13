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