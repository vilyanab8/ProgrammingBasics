int stagesCount = int.Parse(Console.ReadLine());
int roomsCount = int.Parse(Console.ReadLine());

for (int i = stagesCount; i > 0; i--)
{
    for (int j = 0; j < roomsCount; j++)
    {
        if (i == stagesCount)
        {
            Console.Write($"L{i}{j} ");
        }
        else if (i % 2 == 0)
        {
            Console.Write($"O{i}{j} ");
        }
        else
        {
            Console.Write($"A{i}{j} ");
        }
    }
    Console.WriteLine();
}
