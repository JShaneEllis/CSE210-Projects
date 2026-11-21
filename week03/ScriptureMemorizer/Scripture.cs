
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
        // needs to move to program.
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, _words.Count);
    
        Word tempword = _words[magicNumberInt];
        tempword.isHidden();

    
    }
    public string GetDisplayText()
    {
        string text = "";        
        for ( int i = 0; i < _words.Count; i ++)
        {
            text =     
          
        }
        text = $"{_verse}";
        
        return text;
    }
    public bool IsCompletelyHidden()
    {      
        return true;
    }


}
