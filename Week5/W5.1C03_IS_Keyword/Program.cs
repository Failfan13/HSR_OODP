class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");

        List<Person> personList = new() { john, (Person)jane };

        foreach (var someone in personList)
        {
            Console.WriteLine(someone.Introduce());
            if (someone is Student)
            {
                Console.WriteLine(((Student)someone).Status());
            }
        }
    }
}