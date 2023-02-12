class ToDo {
    public List<Task> TaskList;

    public ToDo() => TaskList = new List<Task> ();

    public void AddTask(string taskName) {
        TaskList.Add(new Task(taskName));
    }

    public Task? GetTask(string taskName) {
        var task = TaskList.Find(task => task.Name == taskName);
        if (task != null) {
            return task;
        } else {
            return null;
        }
    }

    public string Report() {
        string tempReport = "";
        foreach(var task in TaskList) {
            tempReport += (task.Info() + "\n");
        }
        return tempReport;
    }
}