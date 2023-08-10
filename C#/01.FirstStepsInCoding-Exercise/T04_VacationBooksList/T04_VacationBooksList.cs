using System;
namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int page = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalHour = page / pagesPerHour;
            int hoursPerDay = totalHour / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}


