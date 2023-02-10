class Program {

    public void printList(List<string> lst) {
        Console.WriteLine($"Amount of tasks: {lst.Count}");
        for (var i = 0; i < lst.Count; i++) {
            Console.WriteLine(lst[i]);
        }
    }

    public void addToList(List<string> lst, string[] args) {
        foreach (var arg in args) {
            lst.Add(arg);
        }
    }

    public void removeFromList(List<string> lst, string[] args) {
        foreach (var arg in args) {
            lst.Remove(arg);
        }
    }
    
    static void Main() {
        Program pr = new Program();
        var list = new List<string> ();
        pr.printList(list);
        pr.addToList(list, new string[] {"Mow lawn", "Pay taxes"});
        pr.printList(list);
        pr.removeFromList(list, new string[] {"Mow lawn"});
        pr.addToList(list, new string[] {"Shopping"});
        pr.printList(list);
    }
}