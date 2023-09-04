using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            //banana, apple, kiwi, cherry, lemon и grapes
            if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            //tomato, cucumber, pepper и carrot
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else if (product != "banana" || product != "apple" || product != "kiwi" || product != "cherry" || product != "lemon" || product != "grapes" || product != "tomato" || product != "cucumber" || product != "pepper" || product != "carrot")
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

