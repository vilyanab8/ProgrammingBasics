int n = int.Parse(Console.ReadLine());
double sum = 0.0;
double average = 0.0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    average = sum / n;
}
Console.WriteLine($"{average:f2}");
