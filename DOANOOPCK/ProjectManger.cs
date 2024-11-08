[Serializable]
public class ProjectManager
{
    private List<Project> projects = new List<Project>();

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

    public Project GetProjectByName(string name)
    {
        return projects.Find(p => p.ProjectName.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
        public List<TaskBase> Tasks { get; set; } = new List<TaskBase>();

        public void ListTasks()
        {
            foreach (var task in Tasks)
            {
                Console.WriteLine($"Task: {task.Name}, Due: {task.DueDate}");
            }
        }
    }

