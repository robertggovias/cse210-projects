using System.ComponentModel;

class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string text)
    {
        _word = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string Display()
    {
        return _isHidden ? new string('_', _word.Length) : _word;
    }
}
