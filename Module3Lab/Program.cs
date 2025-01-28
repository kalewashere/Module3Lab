using System;

namespace TacoBurritoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Taco & Burrito Maker!");
            Console.Write("How hungry are you (1-10)? ");
            int hungerLevel = int.Parse(Console.ReadLine());

            // code goes here - using if-else statement suggest odering tacos, burritos, or both
            // based on hunger
            // inside main
            if (hungerLevel >= 8)
            {
                Console.WriteLine("You're super hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("You are moderately hungry. Go for tacos!");
            }
            else{
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            }
            // Ternary Operator
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend: {recommendation}");

            // Switch statement
            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a taco and burrito champion!");
                    break;
                    case 7: // empty to fill with else if statement indicated above
                    case 8:
                        Console.WriteLine("Taco time!");
                        break;
                    case 4: // same as line 37, but with a else 
                    case 5:
                        Console.WriteLine("Burrito it is!");
                        break;
                    default: // runs when all other options are checked and marked as false
                        Console.WriteLine("Maybe just grab a snack.");
                        break;
            }
        }
    }
}