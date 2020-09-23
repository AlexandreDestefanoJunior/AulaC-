using System;
using System.Collections.Generic;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        var contador = 0;
        if (firstStrand.Length == secondStrand.Length)
        {

            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] == secondStrand[i])
                {
                }
                else
                {
                    contador++;
                }
            }
        }

        else
        {
            throw new System.ArgumentException();
        }

        return contador;
    }
}