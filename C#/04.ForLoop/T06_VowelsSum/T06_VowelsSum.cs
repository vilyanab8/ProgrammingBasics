using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == 'a')
                {
                    sum += 1;
                }
                else if (letter[i] == 'e')
                {
                    sum += 2;
                }
                else if (letter[i] == 'i')
                {
                    sum += 3;
                }
                else if (letter[i] == 'o')
                {
                    sum += 4;
                }
                else if (letter[i] == 'u')
                {
                    sum += 5;
                }

                Console.WriteLine(sum);
            }
        }
    }
}

