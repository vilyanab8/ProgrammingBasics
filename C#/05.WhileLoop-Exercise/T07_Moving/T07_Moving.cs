int widthFreeSpace = int.Parse(Console.ReadLine());
int lengthFreeSpace = int.Parse(Console.ReadLine());
int heightFreeSpace = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

double freeSpace = widthFreeSpace * lengthFreeSpace * heightFreeSpace;
int allSpace = 0;

while (command != "Done")
{
    double boxesCount = double.Parse(command);
    freeSpace = freeSpace - boxesCount;
    if (freeSpace < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
        return;
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{freeSpace} Cubic meters left.");           
        


