public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        if (wordsToHide > 0)
        {
            List<int> indices = Enumerable.Range(0, visibleWords.Count).OrderBy(x => random.Next()).Take(wordsToHide).ToList();

            foreach (int index in indices)
            {
                visibleWords[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
