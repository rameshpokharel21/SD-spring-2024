public static class SumDifferenceSolution
{
    /* If the cost of a bat and a baseball combined is $110 and the bast costs $100 more than the ball, how much is the ball?
    How would you solve other sum/difference pairs? */

    // x + x + 100 = 110
    // 2x + 100 = 110
    // 2x = 10
    // x = 5
    public static void SolveSumDifferenceProblem()
    {
        Console.Write("Enter the sum of two numbers:");
        string sumInput = Console.ReadLine();
        Console.Write("Enter the difference between two numbers:");
        string differenceInput = Console.ReadLine();

        int sumMinusDifference = Int32.Parse(sumInput) - Int32.Parse(differenceInput);
        float lowerNumber = (sumMinusDifference / 2f);
        Console.WriteLine($"The least number is {lowerNumber}.");
        Console.WriteLine($"The greatest number is {(Int32.Parse(sumInput) - lowerNumber)}.");
    }
}