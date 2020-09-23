using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        
        var contadorA = 0;
        var contadorC = 0;
        var contadorG = 0;
        var contadorT = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i].ToString() == "A")
            {
                contadorA++;
            }
            else if (sequence[i].ToString() == "C")
            {
                contadorC++;
            }
            else if (sequence[i].ToString() == "G")
            {
                contadorG++;
            }
            else if (sequence[i].ToString() == "T")
            {
                contadorT++;
            }
            else
            {
                throw new ArgumentException($"Deu erro ({sequence[i]})");
            }

        }
        var expected = new Dictionary<char, int>
        {
            ['A'] = contadorA,
            ['C'] = contadorC,
            ['G'] = contadorG,
            ['T'] = contadorT
        };
        return expected;
    }
}