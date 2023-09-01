using System.Runtime.Intrinsics.X86;

int br1 = int.Parse(Console.ReadLine());
int br2 = int.Parse(Console.ReadLine());
int br3 = int.Parse(Console.ReadLine());
int br4 = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());

double totalSum = br1 * 3.25 + br2 * 4 + br3 * 3.5 + br4 * 8;

double sum = totalSum - 0.05 * totalSum;

if (sum < giftPrice)
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-sum)} leva.");
}
else if (sum >= giftPrice)
{
    Console.WriteLine($"She is left with {Math.Floor(sum-giftPrice)} leva.");
}
