double budget = double.Parse(Console.ReadLine());
int numberOfExtras = int.Parse(Console.ReadLine());
double priceForClothing = double.Parse(Console.ReadLine());

double decorCost = budget * 0.10;
double clothingCost = numberOfExtras * priceForClothing;

if (numberOfExtras > 150)
{
    clothingCost *= 0.90;
}

double totalCost = decorCost + clothingCost;

if (totalCost > budget)
{
    double neededMoney = totalCost - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
}
else
{
    double moneyLeft = budget - totalCost;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}