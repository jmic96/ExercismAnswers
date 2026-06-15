using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder cipher = new StringBuilder();

        foreach (char x in text)
        {
            if (char.IsLetter(x))
            {
                char y = char.IsUpper(x) ? 'A':'a';
                cipher.Append((char)((x-y+shiftKey) % 26 + y));
            }
            else
            {
                cipher.Append(x);
            }
        }
        return cipher.ToString();
    }
}