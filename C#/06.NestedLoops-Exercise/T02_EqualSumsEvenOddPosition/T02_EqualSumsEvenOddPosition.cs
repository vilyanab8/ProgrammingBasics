int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int evenSum = 0;
int oddSum = 0;

for (int i = num1; i <= num2; i++)
{
    string currNum = i.ToString();
	for (int j = 0;	j < currNum.Length; j++)
	{
		int currDigit = int.Parse(currNum.ToString());
		if (j % 2 == 0)
		{
			evenSum += currDigit;
		}
		else
		{
			oddSum += currDigit;
		}
	}
	if (oddSum == evenSum)
	{
		Console.WriteLine(i + " ");
	}
}
