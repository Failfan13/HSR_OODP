class Task {
    public string Name;
    public bool IsDone = false;

    public Task(string name) => Name = name;

    public void Done() {
        IsDone = true;
    }

    public string Info() {
        if (IsDone == false) {
            return $"Task: {Name}, Status: Pending";
        } else {
            return $"Task: {Name}, Status: Done";
        }
    }
}