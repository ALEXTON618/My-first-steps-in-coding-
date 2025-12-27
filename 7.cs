double budget = double.Parse(Console.ReadLine());

int countN = int.Parse(Console.ReadLine());
int countM = int.Parse(Console.ReadLine());
int countP = int.Parse(Console.ReadLine());


double priceN = countN * 250;
double priceM = countM * (priceN * 0.35);
double priceP = countP * (priceN * 0.10);

double allSum = priceN + priceM + priceP;

if (countN > countM)
{
    allSum *= 0.85;//allSum = allSume * 0.85 ili allSum = allSum - (allSum * 0.15);
}
if (allSum <= budget)
{
    Console.WriteLine($"You have {budget - allSum :F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {allSum - budget :F2} leva more!");
}