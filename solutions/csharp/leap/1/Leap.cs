public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isLeap = true;
        bool isCentury = year % 100 == 0;

        if (year % 4 != 0)
        {
            isLeap = false;
        }
        else if (isCentury && year % 400 != 0)
        {
            isLeap = false;
        }

        return isLeap;
    }
}