using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int ddni = int.Parse(Console.ReadLine());
            string pomeshtenie = Console.ReadLine();
            string ochenka = Console.ReadLine();
            double prestoi = 0;
            double ostypka = 0;
            double dni = ddni - 1;
            if (pomeshtenie == "room for one person")
            {
                ostypka = dni * 18.00;


            }
            else if (pomeshtenie == "apartment")
            {
                prestoi = dni * 25.00;

                if (dni > 0 && dni <= 10)
                {
                    ostypka = prestoi - (prestoi * 0.30);
                }
                else if (dni > 10 && dni <= 15)
                {
                    ostypka = prestoi - (prestoi * 0.35);
                }
                else if (dni > 15)
                {
                    ostypka = prestoi - (prestoi * 0.50);
                }




            }
            else if (pomeshtenie == "president apartment")
            {
                prestoi = dni * 35.00;

                if (dni > 0 && dni <= 10)
                {
                    ostypka = prestoi - (prestoi * 0.10);
                }
                else if (dni > 10 && dni <= 15)
                {
                    ostypka = prestoi - (prestoi * 0.15);
                }
                else if (dni > 15)
                {
                    ostypka = prestoi - (prestoi * 0.20);
                }


                //346

            }


            if (ochenka == "positive")
            {
                double bakshish = ostypka + (ostypka * 0.25);
                Console.WriteLine($"{bakshish:F2}");
            }
            else if (ochenka == "negative")
            {
                double bakshish = ostypka - (ostypka * 0.10);
                Console.WriteLine($"{bakshish:F2}");
            }
        }
    }
}


