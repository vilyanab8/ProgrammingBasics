int n = int.Parse(Console.ReadLine());
string dayOrNight = Console.ReadLine();
double totalPrice = 0.0;

if (n < 20)
{
    double startPrice = 0.7;
	double price = 0.0;
	if (dayOrNight == "day")
	{
		price = 0.79;
	}
	else if (dayOrNight == "night")
	{
		price = 0.9;
	}
	totalPrice = startPrice + n * price;
}

else if (n >= 20 && n < 100)
{
	if (dayOrNight == "day" || dayOrNight == "night")
	{
		totalPrice = n * 0.09;
	}
}

else if (n >= 100)
{
	if (dayOrNight == "day" || dayOrNight == "night")
	{
        totalPrice = n * 0.06;
    }
}

Console.WriteLine($"{totalPrice:f2}");
