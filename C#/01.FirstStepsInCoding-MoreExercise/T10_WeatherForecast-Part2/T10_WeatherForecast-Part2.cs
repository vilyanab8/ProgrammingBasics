double degree = double.Parse(Console.ReadLine());

if (degree >= 5.00 && degree <= 11.9)
{
    Console.WriteLine("Cold");
}
else if (degree >= 12.00 && degree <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (degree >= 15.00 && degree <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (degree >= 20.1 && degree <= 25.9)
{
    Console.WriteLine("Warm");
}
else if (degree >= 26.00 && degree <= 35.00)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("unknown");
}
