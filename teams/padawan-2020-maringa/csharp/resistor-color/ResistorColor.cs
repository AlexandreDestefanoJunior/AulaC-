using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int position = 0;
        string[] a = new string[]
            {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        for (int i = 0; i <= 9; i++)
        {
            if (a[i] == color)
            {
                position = i;
            }

        }
        return position;
    }

    public static string[] Colors()
        {
            string[] a = new string[]{"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
            return a;
        }
    
}