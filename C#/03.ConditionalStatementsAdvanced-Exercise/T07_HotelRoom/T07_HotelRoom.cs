using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double sumStudio = 0.0;
            double sumApartment = 0.0;

            if (month == "May" || month == "October")
            {
                sumStudio = nightsCount * 50;
                sumApartment = nightsCount * 65;
            }
            else if (month == "June" || month == "September")
            {
                sumStudio = nightsCount * 75.20;
                sumApartment = nightsCount * 68.70;
            }
            else if (month == "July" || month == "August")
            {
                sumStudio = nightsCount * 76;
                sumApartment = nightsCount * 77;
            }

            if (nightsCount > 7 && nightsCount <= 14 && (month == "May" || month == "October"))
            {
                sumStudio = sumStudio - 0.05 * sumStudio;
            }
            else if (nightsCount > 14 && (month == "May" || month == "October"))
            {
                sumStudio = sumStudio - 0.3 * sumStudio;
            }
            else if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                sumStudio = sumStudio - 0.2 * sumStudio;
            }
            else if (nightsCount > 14)
            {
                sumApartment = sumApartment - 0.1 * sumApartment;
            }

            Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
        }
    }
}

