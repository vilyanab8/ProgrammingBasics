double height = double.Parse(Console.ReadLine());
double sideLength = double.Parse(Console.ReadLine());
double triangleHeight = double.Parse(Console.ReadLine());

double sideArea = height * sideLength;
double windowArea = 1.5 * 1.5;
double twoSides = 2 * sideArea - 2 * windowArea;
double backSide = height * height;
double entrance = 2 * 1.2;
double total = 2 * backSide - entrance;
double subTotal = twoSides + total;
double green = subTotal / 3.4;

double rectangle = 2 * (height * sideLength);
double triangles = 2 * ((height * triangleHeight) / 2);
double total1 = rectangle + triangles;
double red = total1 / 4.3;

Console.WriteLine($"{green:f2}");
Console.WriteLine($"{red:f2}");
