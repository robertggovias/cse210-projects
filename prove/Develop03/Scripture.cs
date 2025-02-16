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
      foreach (Word word in _wordys){
           result += word._word + " ";           
      }
        return result;
    }
    
    
    //private List<String> _words = new List<String>{};
    

    public string GetWordFromList(int index){
        string result2 = "";
        string result3 = "";
        result2 = _wordys[index]._word;
        result3 = _wordys[index]._wordHidden;

        return result2 + result2.Length + result3;
    }
    
    


    
}