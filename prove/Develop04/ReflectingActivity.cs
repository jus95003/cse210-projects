public class ReflectingActivity : Activity
{
    private string[] _memoriesPrompt = new string[4] {
        "--- Think of a time when you stood up for someone else. ---",
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Think of a time when you did something truly selfless. ---"};
    private string[] _questionList = new string[9] {
        "Why was this experience meaningful to you?  ",
        "Have you ever done anything like this before?  ",
        "How did you get started?  ",
        "How did you feel when it was complete?  ",
        "What made this time different than other times when you were not as successful?  ",
        "What is your favorite thing about this experience?  ",
        "What could you learn from this experience that applies to other situations?  ",
        "What did you learn about yourself through this experience?  ",
        "How can you keep this experience in mind in the future?  "};

    public ReflectingActivity() : base()
    {
        _activityName = "Reflecting Activity";

        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void RunReflectingActivity()
    {
        this.DisplayStartMessage();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine(this.GetRandPrompt(_memoriesPrompt));

        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.  ");

        string enter = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine();
        Console.Write("You may begin in: ");

        this.DisplayTimer(9);

        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);

        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.Write(this.GetRandPrompt(_questionList));

            this.DisplaySpinner(10);

            Console.WriteLine();
            Console.WriteLine();

            currentTime = DateTime.Now;
        }

        this.DisplayEndMessage();
    }
}