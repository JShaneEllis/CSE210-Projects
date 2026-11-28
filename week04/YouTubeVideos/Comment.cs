public class Comment
{
    public string _name;
    public  string _comment;
    
    public List<Comment> _comments = new List<Comment>();
    
    public void AddComment(string name, string comment)
    {
       
       _comments.Add(new Comment {_name= name, _comment = comment});

    }
    public string GetDisplayText()
    {
            
        string textCom = "";    
            foreach (Comment c in _comments)
            {
                textCom += $"Name: {c._name}\nComment: {c._comment}\n";
            }         
            return textCom;
        
        

    }

}