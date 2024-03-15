public static class CollatzSequence
{
    /* from https://projecteuler.net/problem=14
    The following iterative sequence is defined for the set of positive integers:
        n -> n/2 (n is even)
        n -> 3n + 1 (n is odd)
    
    Using the rule above and starting with 13, we generate the following sequence:
        13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1

    It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

    Which starting number, under one million, produces the longest chain?*/

    static long selectedStartingNumber = 0;
    static long longestChain = 0;
    static long count = 1;

	public static (long, long) DetermineAnswer()
    {
        for (int i = 1; i < 1_000_000; i++)
        {
            count = 1;
            RunSequence(i);
            if (count > longestChain)
            {
                longestChain = count;
                selectedStartingNumber = i;
            }
        }
        return (selectedStartingNumber, longestChain);
    }
		
    static void RunSequence(long number)
    {
        if (number == 1) { return; }
        else if (number % 2 == 0)
        {
            number = number / 2;
            count++;
            RunSequence(number);
        }
        else
        {
            number = (number * 3) + 1;
            count++;
            RunSequence(number);
        }
    }
}