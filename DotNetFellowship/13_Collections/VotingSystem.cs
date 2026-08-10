using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes =
            new Dictionary<string, int>();

        votes["Alice"] = 10;
        votes["Bob"] = 15;
        votes["Charlie"] = 8;

        SortedDictionary<string, int> sortedVotes =
            new SortedDictionary<string, int>(votes);

        foreach (var vote in sortedVotes)
        {
            Console.WriteLine(
                vote.Key + " : " + vote.Value);
        }
    }
}