
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
        string hideWord = "";
        
        for ( int i = 0; i < _text.Length; i ++)
        {
            hideWord += "_";
        } 
        _text = hideWord;
        _isHidden = true;
       
       
    }
public bool isHidden()
    {
        if (_isHidden != true)
        {
            return false;
        }  
        return true;
    }
public string GetDisplayText()
    {
        string tempWord = "";
        
        if (_isHidden == true)
        {
            Hide();
        } 
       
        tempWord = _text;


        return tempWord;

    }

}
