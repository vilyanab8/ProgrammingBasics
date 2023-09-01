using System.Numerics;

int v = int.Parse(Console.ReadLine());
int p1 = int.Parse(Console.ReadLine());
int p2 = int.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());

double p1Hours = p1 * hours;
double p2Hours = p2 * hours;
double total = p1Hours + p2Hours;

if (total < v)
{
    double totalPersent = total / v * 100;
    double p1Persent = p1Hours / total * 100;
    double p2Persent = p2Hours / total * 100;

    Console.WriteLine($"The pool is {totalPersent:F2}% full. Pipe 1: {p1Persent:F2}%. Pipe 2: {p2Persent:F2}%.");
}

else
{
    double waterMore = total - v;
    Console.WriteLine($"For {hours:F2} hours the pool overflows with {waterMore:F2} liters.");
}
              
