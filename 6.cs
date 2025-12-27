double worldRecord = double.Parse(Console.ReadLine());
double distanceM = double.Parse(Console.ReadLine());
double timePerOneMeters = double.Parse(Console.ReadLine());


double ivanTime = distanceM * timePerOneMeters;// bez zabavqne 
double delayTime = Math.Floor(distanceM / 15) * 12.5;
double finalTimeIvan = ivanTime + delayTime;

if (finalTimeIvan < worldRecord )
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {finalTimeIvan :F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {finalTimeIvan - worldRecord :F2} seconds slower.");
}    