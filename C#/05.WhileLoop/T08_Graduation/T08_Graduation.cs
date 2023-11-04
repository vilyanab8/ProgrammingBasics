string name = Console.ReadLine();
int grade = 1;
double sum = 0.0;
int fails = 0;

while (grade <= 12)
{
    double grades = double.Parse(Console.ReadLine());
    if (grades >= 4)
    {
        sum += grades;
        grade++;
    }
    else
    {
        fails += 1;

    }
    if (fails > 1)
    {
        Console.WriteLine($"{name} has been excluded at {grade} grade"); break;
    }
}
if (fails < 2)
{
    double average = sum / 12;
    Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
}
