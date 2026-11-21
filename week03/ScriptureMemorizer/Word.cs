
public class Word
{
    private string _text;
    private bool _isHidden;
       
public Word(string text)
    {
        _text = text;   
       if (_isHidden == true)
        {
            
        }
       
    }
   
public void Hide()
    {
        _isHidden = true;
    }
public void Show()
    {
      _isHidden = false;  
    }
public bool isHidden()
    {
      
       return true;
      
    }
public string GetDisplayText()
    {
        string tempWord = "";
         for ( int i = 0; i < _words.Count; i ++)
        {
            
           
        }
        
        
        
        return tempWord;

    }

}
