int students = int.Parse(Console.ReadLine());
int greaterThanFive = 0;
int betweenFourAndFive = 0;
int betweenThreeAndFour = 0;
int PoorerThanThree = 0;
double average = 0;

for (int i = 0; i < students; i++)
{
    double gradeInput = double.Parse(Console.ReadLine());
    if (gradeInput >= 5.00)
    { 
        greaterThanFive++;
    }
    else if (gradeInput >= 4.00 && gradeInput <= 4.99)
    { 
        betweenFourAndFive++;
    }
    else if (gradeInput >= 3.00 && gradeInput <= 3.99)
    { 
        betweenThreeAndFour++;
    }
    else if (gradeInput < 3.00)
    { 
        PoorerThanThree++;
    }
    average += gradeInput;
}

Console.WriteLine($"Top students: {((greaterThanFive / (double)students) * 100):f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {((betweenFourAndFive / (double)students) * 100):f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {((betweenThreeAndFour / (double)students) * 100):f2}%");
Console.WriteLine($"Fail: {((PoorerThanThree / (double)students) * 100):f2}%");
Console.WriteLine($"Average: {average / (double)students:f2}");

