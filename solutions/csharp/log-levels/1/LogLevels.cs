static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int closeBracket = 0;
        foreach (char c in logLine)
        {
            if (c == ']')
            {
                break;
            }
            closeBracket++;
        }
        return logLine.Substring(1, closeBracket - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
