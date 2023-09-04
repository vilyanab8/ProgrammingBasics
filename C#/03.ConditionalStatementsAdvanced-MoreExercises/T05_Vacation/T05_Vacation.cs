double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0.0;

if (budget <= 1000)
{
	if (season == "Summer")
	{
		price = 0.65 * budget;
		Console.WriteLine($"Alaska - Camp - {(price):f2}");
	}
	else if (season == "Winter")
	{
		price = 0.45 * budget;
		Console.WriteLine($"Morroco - Camp - {(price):f2}");
	}
}

else if (budget > 1000 && budget <= 3000)
{
	if (season == "Summer")
	{
		price = 0.8 * budget;
		Console.WriteLine($"Alaska - Hut - {(price):f2}");
	}
	else if (season == "Winter")
	{
		price = 0.6 * budget;
		Console.WriteLine($"Morroco - Hut - {(price):f2}");
	}
}

else if (budget > 3000)
{
	if (season == "Summer")
	{
		price = 0.9 * budget;
		Console.WriteLine($"Alaska - Hotel - {(price):f2}");
	}
	else if (season == "Winter")
	{
		price = 0.9 * budget;
		Console.WriteLine($"Morroco - Hotel - {(price):f2}");
	}
}
