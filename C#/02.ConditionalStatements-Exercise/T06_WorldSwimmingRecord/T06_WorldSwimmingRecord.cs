using System;
namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double secRecord = double.Parse(Console.ReadLine());
            double metresDistance = double.Parse(Console.ReadLine());
            double timeInSecFor1Metre = double.Parse(Console.ReadLine());

            double time = metresDistance * timeInSecFor1Metre;
            double every15Metres = Math.Floor(metresDistance / 15) * 12.5;
            double totalTime = time + every15Metres;
            double missedTime = totalTime - secRecord; 

            if (totalTime < secRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            
            else if (totalTime > secRecord)
            {
                Console.WriteLine($"No, he failed! He was {missedTime:F2} seconds slower.");
            }
        }
    }
}

