public class PromptGenerator
{
    public string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    public PromptGenerator()
    {

    }

    public string ReturnPrompt()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, 4);
        return _prompts[i];
    }
}