using System.Net.Security;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Scripture{
    private string _newScripture;
    private List<Word> _wordys = new List<Word>{};
    public int _indexOfHiddenWord = 5;

    public List<int> _aleatoryList = new List<int>{};

    public Scripture(string scripture){
        _newScripture = scripture;   
        SeparateListAndAddToWordObject();
        CreateAleatoryList();             
        RandomIndex();        
    }

    public void CreateAleatoryList(){
        //_aleatoryList = Enumerable.Range(0, _wordys.Count).ToList();
        _aleatoryList = Enumerable.Range(0, _wordys.Count).ToList();
        //_aleatoryList = Enumerable.Range(0, _wordys.Count)  // Genera todos los índices
                             //.OrderBy(x => new Random().Next())  // Los desordena aleatoriamente
          //                   .Take(_wordys.Count / 2)  // Toma la mitad
            //                 .ToList();
    }

    public List<int> _hiddenWord_List_index = new List<int>();

    public void CreateHiddenWordIndex(int i){        
        _hiddenWord_List_index.Add(_aleatoryList[i]);   
    }

    public void RandomIndex(){
        int finalIndex = _aleatoryList.Count()-1;
        while(finalIndex > 0){
            int temporalIndex = _aleatoryList[finalIndex];
            int randomIndex = new Random().Next(0, finalIndex);
            _aleatoryList[finalIndex] = _aleatoryList[randomIndex];
            _aleatoryList[randomIndex] = temporalIndex;
            finalIndex--;
        }}        

        public string ListaAleatoria(){
            
            return string.Join(",",_aleatoryList);
        }

        public string ListaIndexEsconder(){
            
            return string.Join(",",_hiddenWord_List_index);
        }   
        public void wordrestore(){
            _hiddenWord_List_index.RemoveAt(_hiddenWord_List_index.Count-1);
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

        
public int Get_wordys_Count(){
        return _wordys.Count;
    }    

    public string DisplayScriptureList(){          
        string result = "";        
      for (int id = 0; id < _wordys.Count; id++){        
        if(_hiddenWord_List_index.Contains(id)){
        //if (id == _indexOfHiddenWord ){       
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