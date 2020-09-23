using System;
using System.Collections.Generic;


public class Robot
{
    Random rnd;
    public static List<string> NamesInUse = new List<string>();
    const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string _Name;
    public Robot()
    {
        rnd = new Random();
        _Name = generateName();
    }
    public string Name
    {
        get
        {
            return _Name;
        }
    }

    public void Reset()
    {
        NamesInUse.Remove(_Name);
        _Name = generateName();
    }

    public string generateName()
    {
        string temp = alphabet[rnd.Next(0, 25)].ToString() + alphabet[rnd.Next(0, 25)].ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString();
        if (NamesInUse.Contains(temp))
        {
            temp = generateName();
        }
        NamesInUse.Add(temp);
        return temp;
    }
}