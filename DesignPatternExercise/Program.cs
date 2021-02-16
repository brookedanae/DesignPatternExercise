using System;

namespace DesignPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Here at the Grand Circus Factory, we make two items:");
            Console.WriteLine("Chocolate & Wine");
            Console.WriteLine("Which would you prefer?");
            var itemType = Console.ReadLine();

            Console.WriteLine("How many would you like?");
            var itemAmount = double.TryParse(Console.ReadLine(), out double value) ? value : default;

            var factory = new ManufactureFactory();
            var item = ManufactureFactory.Create(itemType, itemAmount);
        }
    }
}
