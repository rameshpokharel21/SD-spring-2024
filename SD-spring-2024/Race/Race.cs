public class Race
{
    public int Length { get; set; }
    public List<Car> Lineup { get; set; }
    public int CurrentLap { get; private set; } = 0;
    public bool IsOngoing { get; private set; } = true;
    public Car? Winner { get; private set; }

    public Race(int length)
    {
        Length = length;
        Lineup = RacingLineup.BuildLineup();
        Winner = Lineup[0];
    }

    public void RunLap(Random randint)
    {
        CurrentLap++;
        Console.WriteLine($"Lap #{CurrentLap}");

        

        foreach (Car currentCar in Lineup)
        {
            int distanceToMove = randint.Next(1, 5);
            currentCar.MoveForward(distanceToMove);
            Console.WriteLine($"The {currentCar.Number} car is at position {currentCar.Position} of {Length}");
            Car? tempWinner = Winner;

            if (currentCar.Position >= Length)
            {
                IsOngoing = false;
                
                tempWinner = currentCar;

                if(tempWinner.Position > Winner.Position)
                {
                    Winner = tempWinner;
                }
            }
        }
    }

    public void DeclareWinner()
    {
        Console.WriteLine($"The winner is the {Winner.Number} car!");
    }
}