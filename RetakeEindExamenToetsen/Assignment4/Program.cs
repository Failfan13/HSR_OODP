class Program
{
    static void Main(string[] args)
    {

        // switch (args[1])
        // {
        //     case "TestCreateTask":
        //         TestCreateTask();
        //         break;
        //     case "TestAddEmployee":
        //         TestAddEmployee();
        //         break;
        //     case "TestSearchEmployee":
        //         TestSearchEmployee();
        //         break;
        //     case "TestAssignTask":
        //         TestAssignTask();
        //         break;
        //     case "TestUpdateTaskStatus":
        //         TestUpdateTaskStatus();
        //         break;
        //     case "TestSearchTasksByAssignee":
        //         TestSearchTasksByAssignee();
        //         break;
        //     case "TestSearchTasksByStatus":
        //         TestSearchTasksByStatus();
        //         break;
        //     default:
        //         Console.WriteLine("Invalid test name. Wrong argument.");
        //         break;
        // }




        TestCreateTask();
        TestAddEmployee();
        TestSearchEmployee();
        TestAssignTask();
        TestUpdateTaskStatus();
        TestSearchTasksByAssignee();
        TestSearchTasksByStatus();

    }


    public static void TestCreateTask()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.CreateTask("Task 1", "Description 1");
        taskManager.CreateTask("Task 2", "Description 2");
        taskManager.CreateTask("Task 3", "Description 3");
        if (taskManager.Tasks.Count == 3)
        {
            Console.WriteLine("CreateTask method works correctly.");
        }
        else
        {
            Console.WriteLine("CreateTask method does not work correctly.");
        }
        //expected output: 
        //CreateTask method works correctly.
    }


    public static void TestAddEmployee()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.AddEmployee("Employee 1");
        taskManager.AddEmployee("Employee 2");
        taskManager.AddEmployee("Employee 3");
        if (taskManager.Employees.Count == 3)
        {
            if (taskManager.Employees.Peek() == "Employee 1")
            {
                Console.WriteLine("AddEmployee method works correctly.");
            }
            else
            {
                Console.WriteLine("AddEmployee method does not work correctly. Doing a peek on the Employees queue returned the wrong result.");
            }

        }
        else
        {
            Console.WriteLine("AddEmployee method does not work correctly. Number of employees in the queue is wrong.");
        }
        //expected output: 
        //AddEmployee method works correctly.
    }



    public static void TestSearchEmployee()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.AddEmployee("Employee 1");
        taskManager.AddEmployee("Employee 2");
        taskManager.AddEmployee("Employee 3");
        bool employee = taskManager.SearchEmployee("Employee 2");
        bool employee2 = taskManager.SearchEmployee("Employee 4");
        Console.WriteLine("We searched for an existing employee, the method returned {0}.", employee);
        Console.WriteLine("We searched for an non-existing employee, the method returned {0}.", employee2);

        //Doing two more tests with hidden names to prevent hardcoding.
        HiddenTests.TestSearchEmployee();

        //Expected output:
        //We searched for an existing employee, the method returned True.
        //We searched for an non-existing employee, the method returned False.
        //We searched for an existing employee, the method returned True.
        //We searched for an non-existing employee, the method returned False.

    }


    public static void TestAssignTask()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.AddEmployee("Employee 1");
        taskManager.AddEmployee("Employee 2");
        taskManager.AddEmployee("Employee 3");
        taskManager.CreateTask("Task 1", "Description 1");
        taskManager.CreateTask("Task 2", "Description 2");
        taskManager.CreateTask("Task 3", "Description 3");
        taskManager.AssignTask("Task 1");
        taskManager.AssignTask("Task 2");
        taskManager.AssignTask("Task 3");
        if (taskManager.Tasks["Task 1"].Assignee == "Employee 1" &&
            taskManager.Tasks["Task 2"].Assignee == "Employee 2" &&
            taskManager.Tasks["Task 3"].Assignee == "Employee 3")
        {
            Console.WriteLine("Employees were assigned in correct order.");
        }
        else
        {
            Console.WriteLine("Employees were not assigned in correct order.");
        }
        //test if all tasks have status InProgress
        if (taskManager.Tasks["Task 1"].Status == TaskStatus.InProgress &&
            taskManager.Tasks["Task 2"].Status == TaskStatus.InProgress &&
            taskManager.Tasks["Task 3"].Status == TaskStatus.InProgress)
        {
            Console.WriteLine("Status updated correctly.");
        }
        else
        {
            Console.WriteLine("Status not updated correctly.");
        }

        //Doing one more tests with hidden names to prevent hardcoding.
        HiddenTests.TestAssignTask();




        //expected output:
        //Employees were assigned in correct order.
        //Status updated correctly.
        //Employees were assigned in correct order.
        //Status updated correctly.


    }


    public static void TestUpdateTaskStatus()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.CreateTask("Task 1", "Description 1");
        taskManager.CreateTask("Task 2", "Description 2");
        taskManager.UpdateTaskStatus("Task 1", TaskStatus.InProgress);
        taskManager.UpdateTaskStatus("Task 2", TaskStatus.Completed);

        Console.WriteLine("We expect a task to be InProgress and it is {0}.", taskManager.Tasks["Task 1"].Status);
        Console.WriteLine("We expect a task to be Completed and it is {0}.", taskManager.Tasks["Task 2"].Status);


        //Few more test with hidden names to prevent hardcoding.
        HiddenTests.TestUpdateTaskStatus();

        //expected output:
        //We expect a task to be InProgress and it is InProgress.
        //We expect a task to be Completed and it is Completed.
        //We expect a task to be InProgress and it is InProgress.
        //We expect a task to be Completed and it is Completed.
        //We expect a task to be New and it is New.
    }


    public static void TestSearchTasksByAssignee()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.Tasks.Add("Task 1", new Task("Task 1", "Description 1", "Employee 1"));
        taskManager.Tasks.Add("Task 2", new Task("Task 2", "Description 2", "Employee 1"));
        taskManager.Tasks.Add("Task 3", new Task("Task 3", "Description 3", "Employee 3"));

        List<Task> tasks = taskManager.SearchTasksByAssignee("Employee 1");
        Console.WriteLine("We expect a list of 2 tasks and we got {0}.", tasks.Count);
        if (tasks[0].Title == "Task 1" && tasks[1].Title == "Task 2")
        {
            Console.WriteLine("It returned the correct tasks titles.");
        }
        else
        {
            Console.WriteLine("It did not return the correct tasks titles.");
        }
        tasks = taskManager.SearchTasksByAssignee("Employee 3");
        Console.WriteLine("We expect a list of 1 task and we got {0}.", tasks.Count);
        if (tasks[0].Title == "Task 3")
        {
            Console.WriteLine("It returned the correct tasks titles.");
        }
        else
        {
            Console.WriteLine("It did not return the correct tasks titles.");
        }

        //Doing two more tests with hidden names to prevent hardcoding.
        HiddenTests.TestSearchTasksByAssignee();


        //expected output: 
        //We expect a list of 2 tasks and we got 2.
        //It returned the correct tasks titles.
        //We expect a list of 1 task and we got 1.
        //It returned the correct tasks titles.
        //We expect a list of 2 tasks and we got 2.
        //It returned the correct tasks titles.
        //We expect a list of 1 task and we got 1.
        //It returned the correct tasks titles.

    }


    public static void TestSearchTasksByStatus()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.CreateTask("Task 1", "Description 1");
        taskManager.CreateTask("Task 2", "Description 2");
        taskManager.CreateTask("Task 3", "Description 3");
        taskManager.UpdateTaskStatus("Task 1", TaskStatus.InProgress);
        List<Task> tasks = taskManager.SearchTasksByStatus(TaskStatus.InProgress);
        Console.WriteLine("We expect a list of 1 task and we got {0}.", tasks.Count);
        if (tasks[0].Title == "Task 1")
        {
            Console.WriteLine("It returned the correct tasks titles.");
        }
        else
        {
            Console.WriteLine("It did not return the correct tasks titles.");
        }
        tasks = taskManager.SearchTasksByStatus(TaskStatus.New);
        Console.WriteLine("We expect a list of 2 task and we got {0}.", tasks.Count);
        if (tasks[0].Title == "Task 2" && tasks[1].Title == "Task 3")
        {
            Console.WriteLine("It returned the correct tasks titles.");
        }
        else
        {
            Console.WriteLine("It did not return the correct tasks titles.");
        }

        //Lets put some different numbers in to prevent hardcoding.
        HiddenTests.TestSearchTasksByStatus();

        //expected output:
        //We expect a list of 1 task and we got 1.
        //It returned the correct tasks titles.
        //We expect a list of 2 task and we got 2.
        //It returned the correct tasks titles.
        //We expect a list of 1 task and we got 1.
        //It returned the correct tasks titles.
        //We expect a list of 0 task and we got 0.
        //No titles to check in a list of 0 items.



    }
}