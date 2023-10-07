using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double sumPoints = points;
            bool flag = false;

            for (int i = 0; i < n; i++)
            {
                string nameJury = Console.ReadLine();
                double pointsJury = double.Parse(Console.ReadLine());
                double momentPoints = (nameJury.Length * pointsJury) / 2;
                sumPoints = sumPoints + momentPoints;
                if (sumPoints >= 1250.5)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - sumPoints:F1} more!");
            }

        }
    }
}



