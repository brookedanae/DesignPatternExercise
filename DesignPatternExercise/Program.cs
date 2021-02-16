using System;

namespace DesignPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                bool isInvalid;
                do
                {
                    Console.WriteLine("Hello! Here at the Grand Circus Factory, we make two items:");
                    Console.WriteLine("Chocolate & Wine" + "\n");
                    Console.WriteLine("Which would you prefer?");
                    var itemType = Console.ReadLine();

                    Console.WriteLine("How many would you like?");
                    var itemAmount = int.TryParse(Console.ReadLine(), out int value) ? value : default;


                    var factory = new ManufactureFactory();
                    var item = factory.Create(itemType, itemAmount);

                    Console.WriteLine($"The price of your items is: {item.GetPrice() * itemAmount}" + "\n");
                    Console.WriteLine("Would you like to purchase more? (y/n)");
                    response = Console.ReadLine().ToLower();
                    isInvalid = response != "y" && response != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("You need to enter a valid response! 'y' or 'n'");
                    }
                } while (isInvalid);
            } while (response == "y");
            Console.WriteLine("Thanks for your business!");
        }


    }


}
