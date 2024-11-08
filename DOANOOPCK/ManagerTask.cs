[Serializable]
public class ManagerTask : TaskBase
{
    public string ManagerNotes { get; set; }
    public string ManagerName { get; set; }
    public string Status { get; set; }

    public ManagerTask(string name, string managerName, DateTime dueDate, string notes, string status)
    {
        Name = name;
        ManagerName = managerName;
        DueDate = dueDate;
        ManagerNotes = notes;
        Status = status;
    }
    public void AddHistory(string propertyName, string oldValue, string newValue)
    {
        string description = $"{propertyName} changed from '{oldValue}' to '{newValue}'";
        History.Add(new TaskHistory(description));
    }
    public override void ExecuteTask()
    {
        Console.WriteLine($"Executing Manager Task: {Name} by {ManagerName}");
    }

    public void UpdateStatus(string newStatus)
    {
        AddHistory("Status", Status, newStatus);
        Status = newStatus;
        Console.WriteLine($"Status updated to {Status} for Manager Task: {Name}");
    }

    public void UpdateDueDate(DateTime newDueDate)
    {
        AddHistory("DueDate", DueDate.ToShortDateString(), newDueDate.ToShortDateString());
        DueDate = newDueDate;
        Console.WriteLine($"Due date updated to {DueDate.ToShortDateString()} for Task: {Name}");
    }
}
