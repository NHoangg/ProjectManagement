[Serializable]
public class Task : TaskBase
{
    public override void ExecuteTask()
    {
        Console.WriteLine("Executing Task: " + Name);
        AddHistory("Executed task.");
    }
}