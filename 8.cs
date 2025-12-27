string name = Console.ReadLine();
int timeSeries = int.Parse(Console.ReadLine());
int relaxTime = int.Parse(Console.ReadLine());

double lunchTime = relaxTime * 1 / 8.0;// 8.0 a ne 8 za da otlichim double a ne int 
double restTime = relaxTime * 1 / 4.0;// 4.0 a ne 4 za da otlichim double a ne int 

double timeLeft = relaxTime - (lunchTime + restTime);

if (timeLeft >= timeSeries)
{
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - timeSeries)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeSeries - timeLeft)} more minutes.");
}