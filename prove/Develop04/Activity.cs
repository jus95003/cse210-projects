public class Activity
{
    protected int _activityDuration;
    protected string _activityName;
    protected string _activityDescription;

    public Activity()
    {
        _activityDuration = 0;

        _activityName = "";

        _activityDescription = "";
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        this.SetDuration();

        Console.Clear();
        Console.Write("Get ready... ");

        this.DisplaySpinner(5);
    }

    public void DisplayEndMessage()
    {
        Console.Write("Well done!!  ");

        this.DisplaySpinner(5);

        Console.WriteLine();
        Console.WriteLine();
        Console.Write($"You have completed another {_activityDuration} seconds of the {_activityName}.  ");

        this.DisplaySpinner(10);
    }

    protected void SetDuration()
    {
        int durationValidate;

        do
        {
            durationValidate = 1;

            Console.Write("How long, in seconds, would you like for your session?  ");

            string durationChoice = Console.ReadLine();

            foreach (Char character in durationChoice)
            {
                if (!Char.IsNumber(character))
                {
                    durationValidate = 0;
                }
            }

            if (durationValidate == 1)
            {
                _activityDuration = Int32.Parse(durationChoice);
            }

        } while (durationValidate == 0);
    }

    protected void DisplayTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}  ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b \b");
        }
    }

    protected void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|  ");
            Thread.Sleep(250);
            Console.Write("\b\b\b \b");
            Console.Write("/  ");
            Thread.Sleep(250);
            Console.Write("\b\b\b \b");
            Console.Write("—  ");
            Thread.Sleep(250);
            Console.Write("\b\b\b \b");
            Console.Write("\\  ");
            Thread.Sleep(250);
            Console.Write("\b\b\b \b");
        }
    }

    protected string GetRandPrompt(string[] prompts)
    {
        int len = prompts.Length;
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, len);
         return prompts[i];
    }
}