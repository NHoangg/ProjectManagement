public class UIHandler
{
    private ProjectManager projectManager;

    public UIHandler(ProjectManager manager)
    {
        projectManager = manager;
    }

    public void ShowMainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nProject Management Menu:");
            Console.WriteLine("1. Create New Project");
            Console.WriteLine("2. Add Task to Existing Project");
            Console.WriteLine("3. Add Manager Task");
            Console.WriteLine("4. Add Development Task");
            Console.WriteLine("5. List Projects");
            Console.WriteLine("6. List Tasks in Project");
            Console.WriteLine("7. View Task History");
            Console.WriteLine("8. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewProject();
                    break;
                case "2":
                    AddTaskToProject();
                    break;
                case "3":
                    AddManagerTask();
                    break;
                case "4":
                    AddDevelopmentTask();
                    break;
                case "5":
                    projectManager.ListProjects();
                    break;
                case "6":
                    ListTasksInProject();
                    break;
                case "7":
                    ViewTaskHistory();
                    break;
                case "8":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void CreateNewProject()
    {
        Console.Write("Enter Project Name: ");
        string projectName = Console.ReadLine();
        Console.Write("Enter Start Date (yyyy-MM-dd): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter End Date (yyyy-MM-dd): ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        Project project = new Project(projectName, startDate, endDate);
        projectManager.AddProject(project);
        Console.WriteLine("Project created successfully.");
    }

    private void AddTaskToProject()
    {
        Console.Write("Enter Project Name to add task: ");
        string projectName = Console.ReadLine();
        Project project = projectManager.GetProjectByName(projectName);

        if (project == null)
        {
            Console.WriteLine("Project not found.");
            return;
        }

        Console.Write("Enter Task Name: ");
        string taskName = Console.ReadLine();
        Console.Write("Enter Due Date (yyyy-MM-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Task task = new Task { Name = taskName, DueDate = dueDate };
        project.AddTask(task);
        task.AddHistory("Task created.");
        Console.WriteLine("Task added to project successfully.");
    }
    private void AddManagerTask()
    {
        Console.Write("Enter Task Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Manager's Name: ");
        string managerName = Console.ReadLine();
        Console.Write("Enter Due Date (yyyy-MM-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Notes: ");
        string notes = Console.ReadLine();
        Console.Write("Enter Status: ");
        string status = Console.ReadLine();

        ManagerTask managerTask = new ManagerTask(name, managerName, dueDate, notes, status);
        projectManager.AddTask(managerTask);
        Console.WriteLine("Manager Task added successfully.");
    }
    private void AddDevelopmentTask()
    {
        Console.Write("Enter Task Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Developer's Name: ");
        string developerName = Console.ReadLine();
        Console.Write("Enter Start Date (yyyy-MM-dd): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Due Date (yyyy-MM-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Details: ");
        string details = Console.ReadLine();
        Console.Write("Enter Status: ");
        string status = Console.ReadLine();
        DevelopmentTask developmentTask = new DevelopmentTask(name, developerName, startDate, dueDate, details, status);
        projectManager.AddTask(developmentTask);
        Console.WriteLine("Development Task added successfully.");
    }
private void ListTasksInProject()
    {
        Console.Write("Enter Project Name to list tasks: ");
        string projectName = Console.ReadLine();
        Project project = projectManager.GetProjectByName(projectName);

        if (project != null)
        {
            project.ListTasks();
        }
        else
        {
            Console.WriteLine("Project not found.");
        }
    }

    private void ViewTaskHistory()
    {
        Console.Write("Enter Project Name: ");
        string projectName = Console.ReadLine();
        Project project = projectManager.GetProjectByName(projectName);

        if (project == null)
        {
            Console.WriteLine("Project not found.");
            return;
        }

        Console.Write("Enter Task Name: ");
        string taskName = Console.ReadLine();
        TaskBase task = project.Tasks.Find(t => t.Name.Equals(taskName, StringComparison.OrdinalIgnoreCase));

        if (task != null)
        {
            task.DisplayHistory();
        }
        else
        {
            Console.WriteLine("Task not found in the project.");
        }
    }
}
