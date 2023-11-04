public class ListingActivity : Activity
{
    private string[] _listingPrompt = new string[5] {
        "--- Who are people that you appreciate? ---",
        "--- What are personal strengths of yours? ---",
        "--- Who are people that you have helped this week? ---",
        "--- When have you felt the Holy Ghost this month? ---",
        "--- Who are some of your personal heroes? ---"};
    private int _listCount = 0;

    public ListingActivity() : base()
    {
        _activityName = "Listing Activity";

        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void RunListingActivity()
    {
        this.DisplayStartMessage();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.WriteLine(this.GetRandPrompt(_listingPrompt));

        Console.WriteLine();
        Console.Write("You may begin in: ");

        this.DisplayTimer(9);
        
        Console.WriteLine();
        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);

        while (currentTime < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            _listCount++;

            currentTime = DateTime.Now;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_listCount} items!");
        Console.WriteLine();

        this.DisplayEndMessage();
    }
}