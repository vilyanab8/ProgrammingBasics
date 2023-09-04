double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int peopleCount = int.Parse(Console.ReadLine());
double price = 0.0;
double priceForTransport = 0.0;

if (category == "VIP")
{
    price = 499.99;
}
else if (category == "Normal")
{
    price = 249.99;
}

if (peopleCount >= 1 && peopleCount <= 4)
{
    priceForTransport = 0.75 * budget;
}
else if (peopleCount >= 5 && peopleCount <= 9)
{
    priceForTransport = 0.6 * budget;
}
else if (peopleCount >= 10 && peopleCount <= 24)
{
    priceForTransport = 0.5 * budget;
}
else if (peopleCount >= 25 && peopleCount <= 49)
{
    priceForTransport = 0.4 * budget;
}
else if (peopleCount >= 50)
{
    priceForTransport = 0.25 * budget;
}

double priceOdd = budget - priceForTransport;
double total = price * peopleCount;

if (total <= priceOdd)
{
    Console.WriteLine($"Yes! You have {(priceOdd-total):f2} leva left.");
}
else if (total > priceOdd)
{
    Console.WriteLine($"Not enough money! You need {(total-priceOdd):f2} leva.");
}
