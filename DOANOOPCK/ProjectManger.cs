using System.Threading.Tasks;

[Serializable]
public class ProjectManager
{
    private List<Project> projects = new List<Project>();
    private List<TaskBase> tasks = new List<TaskBase>();
    public List<TaskBase> Tasks { get { return tasks; } }
    public void AddTask(TaskBase task)
    {
        tasks.Add(task);
    }
    public void AddProject(Project project)
    {
        projects.Add(project);
    }

    public void ListProjects()
    {
        foreach (Project project in projects)
        {
            Console.WriteLine("Project: " + project.ProjectName + ", Start: " + project.StartDate + ", End: " + project.EndDate);
        }
    }
    public void ListTasks()
    {
        foreach (TaskBase task in tasks)
        {
            Console.WriteLine("Task: " + task.Name + ", Due: " + task.DueDate);
        }
    }
    public Project GetProjectByName(string name)
    {
        return projects.Find(p => p.ProjectName.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
        public List<TaskBase> TaskBase { get; set; } = new List<TaskBase>();
    }

