for (int i = 0; i < queries.Length; i++)
{
    // queries[i] aapka andar wala array hai
    for (int j = 0; j < queries[i].Length; j++)
    {
        int value = queries[i][j]; // Har ek number yahan milega
        Console.Write(value + " ");
    }
    Console.WriteLine();
}
