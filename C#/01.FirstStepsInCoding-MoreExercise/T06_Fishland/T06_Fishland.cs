double mackerelPrice = double.Parse(Console.ReadLine());
double sprinklePrice = double.Parse(Console.ReadLine());
double bonitoKilograms = double.Parse(Console.ReadLine());
double scadKilograms = double.Parse(Console.ReadLine());
double clamKilograms = double.Parse(Console.ReadLine());

double bonitoPrice = mackerelPrice + mackerelPrice * 0.60;
double bonitoSum = bonitoKilograms * bonitoPrice;

double scadPrice = sprinklePrice + sprinklePrice * 0.80;
double scadSum = scadKilograms * scadPrice;

double clamSum = clamKilograms * 7.50;

double subTotal = bonitoSum + scadSum + clamSum;
Console.WriteLine($"{subTotal:f2}");

