public class Player
{
    public int RollDie()
    {
        var random = new Random();
        return random.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        var strength = new Random();
        return strength.NextDouble() * 100;
    }
}
