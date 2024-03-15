var randomIntGenerator = new Random();

void RunRace()
{
    Race race = new Race(70);
    while (race.IsOngoing)
    {
        race.RunLap(randomIntGenerator);
    }
    race.DeclareWinner();
}

RunRace();