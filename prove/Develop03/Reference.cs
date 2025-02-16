class Reference{
    private string _reference;
    private string _book;
    private int _chapter;    
    private int  _verseInit;
    private int  _verseEnd;
    public Reference (string book, int chapter, int verseInit, int verseEnd) {
        _book = book;
        _chapter = chapter;
        _verseInit = verseInit;
        _verseEnd = verseEnd;
        _reference = _book + " " + _chapter.ToString() + ":" + _verseInit.ToString() + "-" + _verseEnd.ToString();                
    }
    public Reference(string book, int chapter, int verseInit) {
        _book = book;
        _chapter = chapter;
        _verseInit = verseInit;
        _reference = book + " " + _chapter.ToString() + ":" + _verseInit.ToString();        
    }

    public string GetReference(){
        return _reference;
    }
    

    }
    