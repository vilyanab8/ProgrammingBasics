string input = Console.ReadLine();
int max = int.MinValue;

while (input != "Stop")
{
	int numbers = int.Parse(input);
	if (numbers > max)
	{
		max = numbers;
	}
	input = Console.ReadLine();
}
Console.WriteLine(max);
