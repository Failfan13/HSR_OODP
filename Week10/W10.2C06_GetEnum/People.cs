using System.Collections;

public class People : IEnumerable
{
    public List<Person> ListPerson = new List<Person>();

    public void Add(Person person)
    {
        ListPerson.Add(person);
    }

    public IEnumerator<Person> GetEnumerator()
    {
        foreach (Person person in ListPerson)
        {
            yield return person;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}