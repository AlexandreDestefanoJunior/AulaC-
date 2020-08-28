using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var leap = false;

        if (year % 4 == 0 && year %100 != 0 || year % 400 == 0)
        {

            leap = true;


        }

        return leap;

    }
}