double neededMoney = double.Parse(Console.ReadLine());
double ownedMoney = double.Parse(Console.ReadLine());
int daysCounter = 0;
int spendingCounter = 0;

while (ownedMoney < neededMoney && spendingCounter < 5)
{
    string action = Console.ReadLine();
    double sumMoney = double.Parse(Console.ReadLine());
    if (action == "save")
    {
        ownedMoney += sumMoney;
        spendingCounter = 0;
    }
    else if (action == "spend")
    {
        if (sumMoney > ownedMoney)
        {
            sumMoney = ownedMoney;
        }

        ownedMoney -= sumMoney;
        spendingCounter++;
    }
    daysCounter++;
}

if (spendingCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCounter);
}
if (ownedMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}
