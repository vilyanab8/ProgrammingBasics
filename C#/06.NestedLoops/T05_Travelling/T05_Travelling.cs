while (true)
{
    string destination = Console.ReadLine();
    if (destination == "End")
        break;
    double expences = double.Parse(Console.ReadLine()), savings = 0;

    while (savings < expences)
    {
        double money = double.Parse(Console.ReadLine());
        savings += money;
    }

    Console.WriteLine($"Going to {destination}!");
}
