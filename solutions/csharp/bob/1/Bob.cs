public static class Bob
{
    public static string Response(string statement)
    {
        string response = "";
        string trimmed = statement.Trim();
        bool isQuestion = trimmed.Length > 0 && trimmed[trimmed.Length - 1] == '?';
        bool isShouting = statement == statement.ToUpper() && statement.Any(char.IsLetter);

        if (string.IsNullOrWhiteSpace(statement))
        {
            response = "Fine. Be that way!";
        }
        else if (isShouting && isQuestion)
        {
            response = "Calm down, I know what I'm doing!";
        }
        else if (isShouting)
        {
            response = "Whoa, chill out!";
        }
        else if (isQuestion)
        {
            response = "Sure.";
        }
        else
        {
            response = "Whatever.";
        }
        return response;
    }
}