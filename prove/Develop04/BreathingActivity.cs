public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in... ";
    private string _breatheOut = "Now breathe out... ";

    public BreathingActivity() : base()
    {
        _activityName = "Breathing Activity";

        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingActivity()
    {
        this.DisplayStartMessage();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);

        while (currentTime < endTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(_breatheIn);
            this.DisplayTimer(5);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(_breatheOut);
            this.DisplayTimer(5);

            currentTime = DateTime.Now;
        }

        Console.WriteLine();
        Console.WriteLine();

        this.DisplayEndMessage();
    }
}