using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int departHour = int.Parse(Console.ReadLine());
            int departMin = int.Parse(Console.ReadLine());

            int examStart = examHour * 60 + examMin;
            int depart = departHour * 60 + departMin;
            int difference = (depart - examStart);
            int differenceHours = Math.Abs(difference / 60);
            int differenceMinutes = Math.Abs(difference) - differenceHours * 60;

            if (difference > 0)
            {
                Console.WriteLine("Late");
                if (difference > 60)
                {
                    Console.WriteLine($"{Math.Abs(differenceHours)}:{Math.Abs(differenceMinutes):00} hours after the start"); // повече от час
                }
                else if (difference < 60)
                {
                    Console.WriteLine($"{Math.Abs(differenceMinutes)} minutes after the start"); // по - малко от час
                }
            }
            else if (difference <= 0 && difference >= -30) // ако разликата е отрицателна, значи сме на време ако е 0 - 30
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");

                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMinutes));
                }

            }
            else if (difference < -30) //подранили сме
            {
                Console.WriteLine("Early");
                if (difference < -30 && difference > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMinutes));
                }
                else
                {

                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Abs(differenceHours), Math.Abs(differenceMinutes));
                }
            }
        }
            }
        }
    
