public class Comment
{
    private string _commenterName;
    private string _commenterText;

    public Comment(string commenterName, string commenterText)
    {
        _commenterName = commenterName;
        _commenterText = commenterText;
    }

    public void SetCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public void SetCommenterText(string commenterText)
    {
        _commenterText = commenterText;
    }
    public string GetCommenterText()
    {
        return _commenterText;
    }
}