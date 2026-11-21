
public class Scripture
{
    private Reference _reference;
    private string _verse;
    public List<Word> _words = new List<Word>();

public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _verse =  text;
        

        string[] strings = text.Split(" ");
        for ( int i = 0; i < strings.Length; i ++)
        {
            Word w1 = new Word(strings[i]);
            _words.Add(w1);

        }




    }
public void HideRandomWords(int numberToHide)
    {
       _words[numberToHide].Hide();
    
       
        

    
    }
public string GetDisplayText()
    {
        string text = "";        
        for ( int i = 0; i < _words.Count; i ++)
        {
            text += " " + _words[i].GetDisplayText();   
          
        }
        //text = $"{_verse}";
        
        return text;
    }
public bool IsCompletelyHidden()
    {      
        return true;
    }


}
