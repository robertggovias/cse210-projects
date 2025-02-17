using System.Net.Security;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Scripture{
    private string _newScripture;
    private List<Word> _wordys = new List<Word>{};
    private int _indexOfHiddenWord = -1;
    public Scripture(string scripture){
        _newScripture = scripture;   
        SeparateListAndAddToWordObject();             
    }

    public string GetScripture(){
        return _newScripture;
    }    
    
    public void SeparateListAndAddToWordObject(){
        string[]_scriptureList = _newScripture.Split(' ');
        foreach (string word in _scriptureList){
            _wordys.Add(new Word(word));
        }
        }
        public void HiddenWorddByIndex(int index){
            if (index < 0 && index >= _wordys.Count){
            _indexOfHiddenWord = index;}
        }
    public string DisplayScriptureList(){ 
        string result = "";        
      for (int id = 0; id < _wordys.Count; id++){        
        if (id == _indexOfHiddenWord ){
            result += _wordys[id].GetUnderscore() + " ";
        }
        else {
        
           result += _wordys[id].GetWord() + " ";                      
      }      
     
   }   return result;
    }
    //private List<String> _words = new List<String>{};
    
// this code is just to test if the list is of objects is created, if the undercore version is created, and f I can get the object acording with the index
    public string GetWordFromList(int index){
        string result2 = "";
        string result3 = "";
        result2 = _wordys[index].GetWord();
        result3 = _wordys[index].GetUnderscore();

        return result2 + result2.Length + result3;
    }
    
    


    
}