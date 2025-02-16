class Word{
    public string _word;

    public string _wordHidden;
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
    

    

    }