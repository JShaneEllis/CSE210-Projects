public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is one thing you want to improve on tomorrow?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("If I had one thing I could do better today, what would it be?");
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}