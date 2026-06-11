public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastDigit = number % 10;
        int lastTwo = number % 100;
        string ordinal = "";
        if (lastDigit == 1 && lastTwo != 11)
        {
            ordinal = number + "st";
        }
        else if (lastDigit == 2 && lastTwo != 12)
        {
            ordinal = number + "nd";
        }
        else if (lastDigit == 3 && lastTwo != 13)
        {
            ordinal = number + "rd";
        }
        else
        {
            ordinal = number + "th";
        }
        return $"{name}, you are the {ordinal} customer we serve today. Thank you!";
    }
}
