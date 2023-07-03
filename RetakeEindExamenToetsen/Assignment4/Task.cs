public enum TaskStatus
{
    New,
    InProgress,
    Completed
}


public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Assignee { get; set; }
    public TaskStatus Status { get; set; }

    public Task(string title, string description, string assignee)
    {
        Title = title;
        Description = description;
        Assignee = assignee;
        Status = TaskStatus.New;
    }

}