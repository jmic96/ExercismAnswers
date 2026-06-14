using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder builder = new StringBuilder();
        for (int i=0; i < identifier.Length; i++)
        {
            char x = identifier[i];
            if (x == ' ')
            {
                builder.Append('_');
            }
            else if (char.IsControl(x))
            {
                builder.Append("CTRL");
            }
            else if (x == '-')
            {
                char y = identifier[i+1];
                builder.Append(char.ToUpper(y));
                i++;
            }
            else if (char.IsLetter(x) == false)
            {}
            else if (x >= '\u03B1' && x <= '\u03C9')
            {}
            else 
            {
                builder.Append(x);
            }
        }
        return builder.ToString();
    }
}
