using System;
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett omvandlingsprogram");

            string val = "";

            while (val != "3")
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett av följande alternativ nedan");
                Console.WriteLine("1. Omvandla meter (m) till kilometer (km)");
                Console.WriteLine("2. Omvandla kilometer (km) till meter (m)");
                Console.WriteLine("3. Avsluta programmet");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in en längd i meter");
                        double antalMeter = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Längden som du skrev in är detsamma som {antalMeter / 1000} km");
                        break;

                   case "2":
                        Console.WriteLine("Skriv in en längd i kilometer");
                        double antalKm = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Längden som du skrev in är detsamma som {antalKm * 1000} meter");
                        break;
                   
                    case "3":
                        Console.WriteLine("Programmet avslutas...");
                        break;

                    default:
                        Console.WriteLine("Du valde ett ogiltigt alternativ!");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
