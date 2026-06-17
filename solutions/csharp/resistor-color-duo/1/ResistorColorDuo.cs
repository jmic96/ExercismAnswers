using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> ColorValues = new Dictionary<string, int>
    {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };

    public static int Value(string[] colors)
    {
        int firstDigit = ColorValues[colors[0]];
        int secondDigit = ColorValues[colors[1]];

        return firstDigit * 10 + secondDigit;
    }
}