
[Serializable]
public class DevelopmentTask : TaskBase
{
    public string DeveloperName { get; set; }
    public string DevelopmentDetails { get; set; }
    public DateTime StartDate { get; set; }
    public string Status { get; set; }

    public DevelopmentTask(string name, string developerName, DateTime startDate, DateTime dueDate, string details, string status)
    {
        Name = name;
        DeveloperName = developerName;
        StartDate = startDate;
        DueDate = dueDate;
        DevelopmentDetails = details;
        Status = status;
    }

    public override void ExecuteTask()
    {
        Console.WriteLine($"Executing Development Task: {Name} by {DeveloperName}");
    }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"Status updated to {Status} for Development Task: {Name}");
    }

    public void DisplayTaskInfo()
    {
        Console.WriteLine($"Task: {Name}, Developer: {DeveloperName}, Start: {StartDate.ToShortDateString()}, Due: {DueDate.ToShortDateString()}, Status: {Status}");
    }
}
