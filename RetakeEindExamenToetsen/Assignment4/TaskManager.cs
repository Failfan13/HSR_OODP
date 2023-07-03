public class TaskManager
{
    public Dictionary<string, Task> Tasks = new();
    public Queue<string> Employees = new();

    public void CreateTask(string title, string description)
    {
        Tasks.Add(title, new Task(title, description, null));
    }

    public void AssignTask(string title)
    {
        Tasks[title].Assignee = Employees.Dequeue();
        Tasks[title].Status = TaskStatus.InProgress;
    }

    public void UpdateTaskStatus(string title, TaskStatus newStat)
    {
        Tasks[title].Status = newStat;
    }

    public List<Task> SearchTasksByAssignee(string assignee)
    {
        return Tasks.Where(e => e.Value.Assignee == assignee).Select(e => e.Value).ToList();
    }

    public List<Task> SearchTasksByStatus(TaskStatus status)
    {
        return Tasks.Where(e => e.Value.Status == status).Select(e => e.Value).ToList();
    }

    public void AddEmployee(string employee)
    {
        Employees.Enqueue(employee);
    }

    public bool SearchEmployee(string employee)
    {
        return Employees.Contains(employee);
    }
}