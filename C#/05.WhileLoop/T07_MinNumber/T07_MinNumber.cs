string input = Console.ReadLine();
int min = int.MaxValue;

while (input != "Stop")
{
	int numbers = int.Parse(input);
	if (numbers < min)
	{
		min = numbers;
	}
	input = Console.ReadLine();
}
Console.WriteLine(min);
