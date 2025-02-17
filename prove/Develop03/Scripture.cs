using System.Net.Security;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Scripture{
    private string _newScripture;
    public Scripture(string scripture){
        _newScripture = scripture;   
        SeparateListAndAddToWordObject();
             
    }
    public string GetScripture(){
        return _newScripture;
    }    

private List<Word> _wordys = new List<Word>{};
    
    
    public void SeparateListAndAddToWordObject(){
        string[]_scriptureList = _newScripture.Split(' ');
        foreach (string word in _scriptureList){
            _wordys.Add(new Word(word));
        }
        }
    public string DisplayScriptureList(){ 
        string result = "";
        int pepe = 0;
      foreach (Word word in _wordys){
        
        if (word.GetWord().Length > 5 ){
            result += word.GetUnderscore();
        }
        else {
        
           result += word.GetWord() + " ";                      
      }
      pepe++;}
        return result;
   }
       
    //private List<String> _words = new List<String>{};
    

    public string GetWordFromList(int index){
        string result2 = "";
        string result3 = "";
        result2 = _wordys[index].GetWord();
        result3 = _wordys[index].GetUnderscore();

        return result2 + result2.Length + result3;
    }
    
    


    
}