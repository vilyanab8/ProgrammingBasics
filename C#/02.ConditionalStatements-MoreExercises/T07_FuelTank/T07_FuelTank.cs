string text = Console.ReadLine();
double n = double.Parse(Console.ReadLine());

if (n >= 25)
{
    Console.WriteLine($"You have enough {text}.");
}
else if (n < 25)
{
    Console.WriteLine($"Fill your tank with {text}!");
}

else if ((text != "Diesel") || (text != "Gasoline") || (text != "Gas") || (text != "Kerosene"))
{
    Console.WriteLine("Invalid fuel!");
}
