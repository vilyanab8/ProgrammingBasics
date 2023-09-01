int days = int.Parse(Console.ReadLine());
int kgFood = int.Parse(Console.ReadLine());
double dogFood = double.Parse(Console.ReadLine());
double catFood = double.Parse(Console.ReadLine());
double turtleFood = double.Parse(Console.ReadLine());

double needDogFood = days * dogFood;
double needCatFood = days * catFood;
double needTurtleFood = days * (turtleFood/1000);

double totalFood = needDogFood + needCatFood + needTurtleFood;

if (totalFood >= kgFood)
{
    Console.WriteLine($"{Math.Ceiling(totalFood-kgFood)} more kilos of food are needed.");
}
else if (totalFood < kgFood)
{
    Console.WriteLine($"{Math.Floor(kgFood-totalFood)} kilos of food left.");
}

