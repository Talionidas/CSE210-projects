using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words;

    public Scripture(string text, Reference reference)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(ScriptureReference.ToString());
        Console.WriteLine(string.Join(" ", Words.Select(w => w.ToString())));
    }

    public void HideRandomWords()
{
    Random random = new Random();
    int wordsToHide = random.Next(1, Words.Count / 4 + 1); 

    int hiddenCount = 0;
    while (hiddenCount < wordsToHide)
    {
        int index = random.Next(Words.Count);
        if (!Words[index].IsHidden)
        {
            Words[index].IsHidden = true;
            hiddenCount++;
        }
    }
}
}