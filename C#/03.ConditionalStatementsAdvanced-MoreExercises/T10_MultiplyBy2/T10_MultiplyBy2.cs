double num = double.Parse(Console.ReadLine());

double result = 0;

while (num >= 0)
{
    result = num * 2;
    Console.WriteLine($"Result: {result:f2}");
    num = double.Parse(Console.ReadLine());
}
if (num < 0)
{
    Console.WriteLine("Negative number!");
}
