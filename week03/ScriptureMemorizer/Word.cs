
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
            hideWord += "_ ";
        } 
        _text = hideWord;
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
        
        if (_isHidden == true)
        {
            Hide();
        } 
        else
        {
            Show();
        }
        tempWord = _text;


        return tempWord;

    }

}
