double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0.0;

if (budget <= 100)
{
    Console.WriteLine("Economy class");
	if (season == "Summer")
	{
		price = 0.35 * budget;
		Console.WriteLine($"Cabrio - {(price):f2}");
	}
	else if (season == "Winter")
	{
		price = 0.65 * budget;
		Console.WriteLine($"Jeep - {(price):f2}");
	}
}

else if (budget > 100 && budget <= 500)
{
	Console.WriteLine("Compact class");
	if (season == "Summer")
	{
		price = 0.45 * budget;
		Console.WriteLine($"Cabrio - {(price):f2}");
	}
	else if (season == "Winter")
	{
		price = 0.8 * budget;
		Console.WriteLine($"Jeep - {(price):f2}");
	}
}

else if (budget > 500)
{
	Console.WriteLine("Luxury class");
	if (season == "Summer" || season == "Winter")
	{
		price = 0.9 * budget;
		Console.WriteLine($"Jeep - {(price):f2}");
	}
}


