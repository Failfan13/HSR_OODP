public class Student
{

    public string ID { get; set; }
    public string Name { get; set; }


    public Student(string id, string name)
    {
        Name = name;
        ID = id;
    }

}