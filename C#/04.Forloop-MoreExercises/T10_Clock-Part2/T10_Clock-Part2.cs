for (int h = 0; h < 24; h++)
{
    for (int min = 0; min < 60; min++)
    {
        for (int sec = 0; sec < 60; sec++)
        {
            Console.WriteLine($"{h:D2}:{min:D2}:{sec:D2}");
        }
    }
}
