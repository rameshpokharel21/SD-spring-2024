
using System;
using System.Collections.Generic;
using System.Linq;



public class Race2
{
    public int Length { get; set; }
    public List<Car> Lineup { get; set; }
    public int CurrentLap { get; private set; } = 0;
    public bool IsOngoing { get; private set; } = true;
    public Car Finisher {get; private set;}
    public List<Car> Finishers { get; private set; }

    public Race2(int length)
    {
        Length = length;
        Lineup = RacingLineup.BuildLineup();
        Finisher = Lineup[0];  
        Finishers = [];
    }

    /*
        this method changes bool IsOngoing to false when at least
        one car reaches the race length. And adds the cars to the list
        of Finishers which ever completes the race in this last lap.
    */
    public void RunLap(Random randint)
    {
        CurrentLap++;
        Console.WriteLine($"Lap #{CurrentLap}");
        
        
        foreach (Car currentCar in Lineup)
        {
            int distanceToMove = randint.Next(1, 5);
            currentCar.MoveForward(distanceToMove);
            Console.WriteLine($"The {currentCar.Number} car is at position {currentCar.Position} of {Length}");
            
            
            if (currentCar.Position >= Length )
            {
                IsOngoing = false;
                Finisher = currentCar;
                Finishers.Add(Finisher);
            }
        }
                
    }


    /*
        prints the list of finishers in the last lap
        and declare the winner out of finishers
        using DeclareWinners method.
    */
    public void DeclareFinishersAndWinners()
    {
        Console.WriteLine("\nThe finishers are:");
        foreach(var finisher in Finishers)    
        {
            Console.WriteLine($" number \"{finisher.Number}\" with distance {finisher.Position}.");

        }

        DeclareWinners();
        Console.WriteLine();
    }

    /*
        Finds the car with max distance moved from the list of Finishers using
        Linq maxBy method.
        if there are more cars with the max distance, it adds to RaceWinners list.
        Finally prints all the RaceWinners.
    */
    private void DeclareWinners(){
        List<Car> RaceWinners = [];
        var OneWinner = Finishers.MaxBy(car => car.Position);
        ArgumentNullException.ThrowIfNull(OneWinner);
        Console.WriteLine("\n");
        foreach(var car in Finishers)
        {
            if(car.Position == OneWinner.Position)
            {
                RaceWinners.Add(car);
            }

        }

        Console.Write("The race winner is number");
        foreach(var winner in RaceWinners)
        { 
            Console.Write($" \"{winner.Number}\" ");     
        }
        Console.WriteLine($"with distance: {RaceWinners[0].Position}");
    }
}