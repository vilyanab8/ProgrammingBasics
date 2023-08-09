double w = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double w1 = w * 100;
double h1 = h * 100;
double metWithout = h1 - 100;
double tables = Math.Round(metWithout / 70);
double col = Math.Round(w1 / 120);

double total = col * tables - 3;
Console.WriteLine(total);
