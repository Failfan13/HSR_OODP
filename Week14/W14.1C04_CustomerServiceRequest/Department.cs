using System;
using System.Collections.Generic;

public class Department
{
    public string Name { get; set; }
    private Queue<Request> _requests;

    public Department(string name)
    {
        Name = name;
        _requests = new Queue<Request>();
    }

    public void AddRequest(Request request) => _requests.Enqueue(request);

    public Request SolveNextRequest() => _requests.Dequeue();
    public Request GetNextRequest() => _requests.Peek();

    public void PrintAllRequests()
    {
        foreach (Request rec in _requests)
        {
            Console.WriteLine(rec.ToString() + "\n");
        }
    }
}