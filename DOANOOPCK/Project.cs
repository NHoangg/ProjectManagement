[Serializable]
public class Project
{
    public string ProjectName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    private List<TaskBase> tasks = new List<TaskBase>();

    public Project(string projectName, DateTime startDate, DateTime endDate)
    {
        ProjectName = projectName;
        StartDate = startDate;
        EndDate = endDate;
    }

    public List<TaskBase> Tasks { get { return tasks; } }

    public void AddTask(TaskBase task)
    {
        tasks.Add(task);
    }

    public void ListTasks()
    {
        Console.WriteLine($"\nTasks in Project: {ProjectName}");
        foreach (TaskBase task in tasks)
        {
            Console.WriteLine("Task: " + task.Name + ", Due: " + task.DueDate);
        }
    }
}