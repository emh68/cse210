using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordArray = text.Split(' ');
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words.Add(new Word(wordArray[i]));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        if (wordsToHide > 0)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < visibleWords.Count; i++)
            {
                indices.Add(i);
            }

            // Shuffle indices using Fisher-Yates algorithm
            for (int i = indices.Count - 1; i > 0; i--)
            {
                int j = _random.Next(0, i + 1);
                int temp = indices[i];
                indices[i] = indices[j];
                indices[j] = temp;
            }

            indices.RemoveRange(wordsToHide, indices.Count - wordsToHide);

            foreach (int index in indices)
            {
                visibleWords[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> wordDisplayTexts = new List<string>();
        foreach (Word word in _words)
        {
            wordDisplayTexts.Add(word.GetDisplayText());
        }

        string displayText = $"{_reference.GetDisplayText()}: {string.Join(" ", wordDisplayTexts)}";
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
