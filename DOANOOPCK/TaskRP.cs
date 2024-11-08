[Serializable]
public class TaskReport
{
    private ProjectManager projectManager;

    public TaskReport(ProjectManager manager)
    {
        projectManager = manager;
    }

    public void GenerateReport()
    {
        Console.WriteLine("\nProject Task Report:");
        projectManager.ListTasks(); // Display tasks in the console
    }

    public void SaveReportToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Project Task Report:");
                foreach (TaskBase task in projectManager.Tasks)
                {
                    writer.WriteLine($"Task: {task.Name}, Due: {task.DueDate}");
                }
            }
            Console.WriteLine("Report saved successfully to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving report to file: {ex.Message}");
        }
    }
}
