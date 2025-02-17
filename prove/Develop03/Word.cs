class Word{
    private string _word;

    private string _wordHidden;
    public Word(string text){
        _word = text;
        GetUnderScoreVersionFromWord();
    }
    
    public string GetWord(){
        return _word;
    }

    public void GetUnderScoreVersionFromWord(){
        string under = "";
        for (int i = 0; i < _word.Length; i++){
        under = under + "_";
        }
        _wordHidden = under;        
    }

    public string GetUnderscore(){
        return _wordHidden;
    }
    

    

    }