int firstTime = int.Parse(Console.ReadLine()); //35
int secondTime = int.Parse(Console.ReadLine());//30
int thirdTime = int.Parse(Console.ReadLine()); //25

int totalTime = firstTime + secondTime + thirdTime;
//90 sek = 1 min 30 sek

int minutes = totalTime / 60;
int seconds = totalTime % 60;

if (seconds <= 9)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
