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
        int wordsToHide = Math.Min(numberToHide, _words.Count);
        List<int> indices = Enumerable.Range(0, _words.Count).OrderBy(x => random.Next()).Take(wordsToHide).ToList();

        foreach (int index in indices)
        {
            _words[index].Hide();
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