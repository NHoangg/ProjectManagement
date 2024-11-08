public class Program
{
    static void Main(string[] args)
    {
        ProjectManager projectManager;
        FileHandler fileHandler = new FileHandler();
        string filePath = "project_data.bin";

        projectManager = fileHandler.DeserializeFromFile<ProjectManager>(filePath) ?? new ProjectManager();
        UIHandler uiHandler = new UIHandler(projectManager);

        Console.WriteLine("Welcome to Project Management Application!");

        uiHandler.ShowMainMenu();

        fileHandler.SerializeToFile(filePath, projectManager);
        Console.WriteLine("Project data has been saved.");
    }
}