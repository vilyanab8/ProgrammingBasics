using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string holiday = "";
            double sum = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    sum = budget * 0.3;
                    holiday = "Camp";
                }
                else if (season == "winter")
                {
                    sum = budget * 0.7;
                    holiday = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sum = budget * 0.4;
                    holiday = "Camp";
                }
                else if (season == "winter")
                {
                    sum = budget * 0.8;
                    holiday = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                holiday = "Hotel";
                if (season == "summer" || season == "winter")
                {
                    sum = budget * 0.9;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holiday} – {Math.Round(sum),2}");
        }
    }
}

