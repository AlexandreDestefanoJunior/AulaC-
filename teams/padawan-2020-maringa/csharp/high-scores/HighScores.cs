using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class HighScores
{
    public List<int> Lista { get; set; }

    public HighScores(List<int> list)
    {
        Lista = list;
    }

    public List<int> Scores()
    {
        return Lista;
    }

    public int Latest()
    {
        return Lista[Lista.Count - 1];
    }

    public int PersonalBest()
    {
        var maior = 0;
        for (int i = 0; i < Lista.Count; i++)
        {
            if (maior < Lista[i])
            {
                maior = Lista[i];
            }
        }



        return maior;
    }

    public List<int> PersonalTopThree() => Lista.OrderByDescending(item => item).Take(3).ToList();
}