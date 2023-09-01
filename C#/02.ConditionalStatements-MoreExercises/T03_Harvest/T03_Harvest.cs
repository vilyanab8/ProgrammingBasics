int vineyardKilometers = int.Parse(Console.ReadLine());
double grape = double.Parse(Console.ReadLine());
int vineLiters = int.Parse(Console.ReadLine());
int peopleForWork = int.Parse(Console.ReadLine());

double grapeTotal =vineyardKilometers * grape;
double vine = (0.4 * grapeTotal) / 2.5;

if (vine >= vineLiters)
{
    double odd = vine - vineLiters;
    Console.WriteLine($"Good harvest this year! Total wine: {vine:f2} liters.");
    Console.WriteLine($"{odd:f2} liters left -> {(odd/peopleForWork):f2} liters per person.");
}
else
{
    double need = vineLiters - vine;
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(need)} liters wine needed.");
}
