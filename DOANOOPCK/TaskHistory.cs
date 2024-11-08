[Serializable]
public class TaskHistory
{
    public DateTime ChangeDate { get; set; }
    public string Description { get; set; }

    public TaskHistory(string description)
    {
        ChangeDate = DateTime.Now;
        Description = description;
    }

    public void DisplayHistory()
    {
        Console.WriteLine($"{ChangeDate}: {Description}");
    }
}