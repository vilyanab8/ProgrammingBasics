string text = Console.ReadLine();
string book = string.Empty;
int count = 0;

while (book != text)
{
	book = Console.ReadLine();
	if (book == "No More Books")
	{
		Console.WriteLine("The book you search is not here!");
		Console.WriteLine($"You checked {count} books.");
		break;
	}
	else if (book == text)
	{
		
		Console.WriteLine($"You checked {count} books and found it.");
	}
	count++;
}
