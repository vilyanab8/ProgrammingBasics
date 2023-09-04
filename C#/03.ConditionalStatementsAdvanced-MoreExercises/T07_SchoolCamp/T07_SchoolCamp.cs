string season = Console.ReadLine();
string group = Console.ReadLine();
int students = int.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());

double price = 0.0;
double totalPrice = 0.0;

if (season == "Winter")
{
	if (group == "boys" || group == "girls")
	{
		price = students * 9.60 * nights;
	}
	else if (group == "mixed")
	{
		price = students * 10 * nights;
	}
}

else if (season == "Spring")
{
    if (group == "boys" || group == "girls")
    {
        price = students * 7.20 * nights;
    }
    else if (group == "mixed")
    {
        price = students * 9.50 * nights;
    }
}

else if (season == "Summer")
{
    if (group == "boys" || group == "girls")
    {
        price = students * 15 * nights;
    }
    else if (group == "mixed")
    {
        price = students * 20 * nights;
    }
}

if (students >= 50)
{
    totalPrice = price - price * 0.5;
}
else if (students >= 20 && students < 50)
{
    totalPrice = price - price * 0.15;
}
else if (students >= 10 && students < 20)
{
    totalPrice = price - price * 0.05;
}
else
{
    totalPrice = price;
}

if (season == "Winter")
{
    if (group == "girls")
    {
        Console.WriteLine($"Gymnastics {(totalPrice):f2} lv.");
    }
    else if (group == "boys")
    {
        Console.WriteLine($"Judo {(totalPrice):f2} lv.");
    }
    else if (group == "mixed")
    {
        Console.WriteLine($"Ski {(totalPrice):f2} lv.");
    }
}

if (season == "Spring")
{
    if (group == "girls")
    {
        Console.WriteLine($"Atletics {(totalPrice):f2} lv.");
    }
    else if (group == "boys")
    {
        Console.WriteLine($"Tennis {(totalPrice):f2} lv.");
    }
    else if (group == "mixed")
    {
        Console.WriteLine($"Cycling {(totalPrice):f2} lv.");
    }
}

if (season == "Summer")
{
    if (group == "girls")
    {
        Console.WriteLine($"Volleyball {(totalPrice):f2} lv.");
    }
    else if (group == "boys")
    {
        Console.WriteLine($"Football {(totalPrice):f2} lv.");
    }
    else if (group == "mixed")
    {
        Console.WriteLine($"Swimming {(totalPrice):f2} lv.");
    }
}
