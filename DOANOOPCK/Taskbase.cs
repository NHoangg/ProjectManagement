[Serializable]
public abstract class TaskBase
{
    public string Name { get; set; }
    public DateTime DueDate { get; set; }
    public List<TaskHistory> History { get; private set; } = new List<TaskHistory>();

    public abstract void ExecuteTask();

    public void AddHistory(string description)
    {
        History.Add(new TaskHistory(description));
        Console.WriteLine("Task history updated.");
    }

    public void DisplayHistory()
    {
        Console.WriteLine($"\nHistory for Task: {Name}");
        foreach (var entry in History)
        {
            entry.DisplayHistory();
        }
    }
}