string typeFuel = Console.ReadLine();
double fuel = double.Parse(Console.ReadLine());
string clubCard = Console.ReadLine();

double price = 0.0;
double totalPrice = 0.0;
double gasolinePerLitter = 2.22;
double dieselPerLitter = 2.33;
double gasPerLitter = 0.93;

if (typeFuel == "Gas")
{
    price = gasPerLitter * fuel;
}
else if (typeFuel == "Gasoline")
{
    price = gasolinePerLitter* fuel;
}
else if (typeFuel == "Diesel")
{
    price = dieselPerLitter * fuel;
}

if (clubCard == "Yes")
{
    if (typeFuel == "Gas")
    {
        totalPrice = (gasPerLitter - 0.08) * fuel;
    }
    else if (typeFuel == "Gasoline")
    {
        totalPrice = (gasolinePerLitter - 0.18) * fuel;
    }
    else if (typeFuel == "Diesel")
    {
        totalPrice = (dieselPerLitter - 0.12) * fuel;
    }
}
else if (clubCard == "No")
{
    if (typeFuel == "Gas")
    {
        totalPrice = price;
    }
    else if (typeFuel == "Gasoline")
    {
        totalPrice = price;
    }
    else if (typeFuel == "Diesel")
    {
        totalPrice = price;
    }
}

if (fuel >= 20 && fuel <= 25)
{
    totalPrice = totalPrice - 0.08 * totalPrice;
}
else if (fuel > 25)
{
    totalPrice = totalPrice - 0.1 * totalPrice;
}

Console.WriteLine($"{(totalPrice):f2} lv.");
