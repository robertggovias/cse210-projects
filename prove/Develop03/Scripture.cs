using System.Net.Security;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Scripture
{
    private List<Word> _words; /*  = new List<Word>{}; */
    private List<int> _aleatoryList;
    private int _curr_index = 0;

    public Scripture(string scripture)
    {
        _words = scripture.Split(' ').Select(word => new Word(word)).ToList();
        _aleatoryList = Enumerable.Range(0, _words.Count).ToList();
        ShuffleList();
    }

    public void setScripture(string scripture)
    {
        _words = scripture.Split(' ').Select(word => new Word(word)).ToList();
        _aleatoryList = Enumerable.Range(0, _words.Count).ToList();
        ShuffleList();
    }

    public void ShuffleList()
    {
        Random rnd = new Random();
        for (int i = _aleatoryList.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            (_aleatoryList[i], _aleatoryList[j]) = (_aleatoryList[j], _aleatoryList[i]);
        }
    }

    public void HideNextWord()
    {
        if (_curr_index < _words.Count)
        {
            int wordIndex = _aleatoryList[_curr_index];
            _words[wordIndex].Hide();
            _curr_index++;
        }
    }

    public void restoreLastHiddenWord()
    {
        if (_curr_index > 0)
        {
            _curr_index--;
            int wordIndex = _aleatoryList[_curr_index];
            _words[wordIndex].Show();
        }
    }

    public string Display()
    {
        return string.Join(" ", _words.Select(word => word.Display()));
    }

    public int GetCurrentIndex()
    {
        return _curr_index;
    }

    public int SetCurrentIndex(int index)
    {
        _curr_index = index;
        return _curr_index;
    }

    public int GetWordCount()
    {
        return _words.Count;
    }
}
