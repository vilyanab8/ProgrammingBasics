int capacity = int.Parse(Console.ReadLine());
int fansCount = int.Parse(Console.ReadLine());

int a = 0;
int b = 0;
int v = 0;
int g = 0;

for (int i = 0; i < fansCount; i++)
{
    string sector = Console.ReadLine();
	if (sector == "A")
	{
		a++;
	}
	else if (sector == "B")
	{
		b++;
	}
	else if (sector == "V")
	{
		v++;
	}
	else if (sector == "G")
	{
		g++;
	}
}
Console.WriteLine($"{(a * 1.0 /fansCount * 100):f2}%");
Console.WriteLine($"{(b * 1.0 /fansCount * 100):f2}%");
Console.WriteLine($"{(v * 1.0 /fansCount * 100):f2}%");
Console.WriteLine($"{(g * 1.0 /fansCount * 100):f2}%");
Console.WriteLine($"{(fansCount * 1.0 /capacity * 100):f2}%");
