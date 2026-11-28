public class Video
{
    public string _title;
    public string _author;
    public int _lenght;
    
    


    public string GetDisplayText()
    {
        Comment c1 = new Comment();
        
        string comment = c1.GetDisplayText();
        string display = $"Video title: {_title}\nAuthor: {_author}\nLenght: {_lenght} seconds.\nComments:{comment}";
        
        
        
        return display;


    }
}
