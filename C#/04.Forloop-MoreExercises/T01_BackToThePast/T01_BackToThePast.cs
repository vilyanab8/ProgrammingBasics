double money = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());
double yearsOld = 17;

for (int i = 1800; i <= year; i++)
{
    if (i % 2 == 0)
    {
        money = money - 12000;
    }
    else
    {
        yearsOld += 2;
        money = money - (12000 + (50 * yearsOld));
    }
}


if (money >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {(Math.Abs(money)):f2} dollars to survive.");
}
