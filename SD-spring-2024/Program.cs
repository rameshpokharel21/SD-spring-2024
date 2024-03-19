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

void AnswerCollatzQuestion()
{
    (long Number, long Terms) answer = CollatzSequence.DetermineAnswer();
    Console.WriteLine($"The number with the longest chain is {answer.Number} with {answer.Terms} terms.");
}

var watch = System.Diagnostics.Stopwatch.StartNew();
 AnswerCollatzQuestion();
watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine($"Took {elapsedMs} ms");


// SumDifferenceSolution.SolveSumDifferenceProblem();
