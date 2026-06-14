using System;
using System.Linq;

public class Anagram
{
    private readonly string baseWord;   // store the original word
    private readonly string baseKey;    // store its sorted form

    // CONSTRUCTOR — just saves the word and precomputes its sorted key.
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
        this.baseKey = SortedKey(baseWord);
    }

    // The actual matching method.
    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches
            .Where(pm => SortedKey(pm) == baseKey                              // same letters
                      && !pm.Equals(baseWord, StringComparison.OrdinalIgnoreCase)) // not itself
            .ToArray();
    }

    // The sort helper — THIS is your "convert to sorted string" method.
    private static string SortedKey(string word)
    {
        return new string(word.ToLower().OrderBy(c => c).ToArray());
    }
}