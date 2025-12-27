double vacationPrice = double.Parse(Console.ReadLine());

int numberOfPuzzles = int.Parse(Console.ReadLine());
int numberOfTalkingDolls = int.Parse(Console.ReadLine());
int numberOfTeddyBears = int.Parse(Console.ReadLine());
int numberOfMinions = int.Parse(Console.ReadLine());
int numberOfTrucks = int.Parse(Console.ReadLine());

double totalSum = numberOfPuzzles * 2.60 + numberOfTalkingDolls * 3.00 + numberOfTeddyBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2.00;

int totalToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;

if (totalToys >= 50)
{
    totalSum *= 0.75;
}

double rent = totalSum * 0.10;
double profit = totalSum - rent;

if (profit >= vacationPrice)
{
    Console.WriteLine($"Yes! {profit - vacationPrice:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {vacationPrice - profit:F2} lv needed.");
}