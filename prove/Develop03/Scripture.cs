using System.Net.Security;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Scripture{
    private string _newScripture;
    private List<Word> _wordys = new List<Word>{};
    public int _indexOfHiddenWord = 0;

    public List<int> _indexHiddenList = new List<int>{};

    public Scripture(string scripture){
        _newScripture = scripture;   
        SeparateListAndAddToWordObject();
        CreateIdexHiddenList();             
        RandomIndex();
    }

    public void CreateIdexHiddenList(){
        _indexHiddenList = Enumerable.Range(0, _wordys.Count).ToList();
    }

    public void RandomIndex(){
        int finalIndex = _indexHiddenList.Count()-1;
        while(finalIndex > 0){
            int temporalIndex = _indexHiddenList[finalIndex];
            int randomIndex = new Random().Next(0, finalIndex);
            _indexHiddenList[finalIndex] = _indexHiddenList[randomIndex];
            _indexHiddenList[randomIndex] = temporalIndex;
            finalIndex--;

        }}
        public string ListaAleatoria(){
            
            return string.Join(",",_indexHiddenList);
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
public int GetHiddenIndex(){
        return _indexOfHiddenWord;
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
    /* public string GetWordFromList(int index){
        string result2 = "";
        string result3 = "";
        result2 = _wordys[index].GetWord();
        result3 = _wordys[index].GetUnderscore();

        return result2 + result2.Length + result3;
    } */
    
    


    
}