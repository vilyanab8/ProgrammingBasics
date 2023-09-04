using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // плод  banana  apple    orange  grapefruit kiwi   pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85

            //    Събота и неделя магазинът работи на по - високи цени:
            // плод  banana   apple   orange  grapefruit kiwi   pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20

            //въведени от потребителя, и пресмята цената според цените от таблиците по-горе.Резултатът да се отпечата закръглен с 2 цифри
            //    след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "grapes") price = 4.20;
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}
