using System.Collections.Generic;

public enum Course
{
    Django,
    OODP,
    Project
}

public class StudentEnrollmentSystem
{
    public Dictionary<Course, Queue<Student>> Waitlist;
    public Dictionary<Course, List<Student>> EnrolledStudents;

    public StudentEnrollmentSystem()
    {
        Waitlist = new Dictionary<Course, Queue<Student>>();
        EnrolledStudents = new Dictionary<Course, List<Student>>();

        foreach (Course course in Enum.GetValues(typeof(Course)))
        {
            Waitlist[course] = new Queue<Student>();
            EnrolledStudents[course] = new List<Student>();
        }
    }

    public void EnrollStudent(string name, string id, Course course)
    {
        Waitlist[course].Enqueue(new Student(id, name));
    }

    public string CheckStatus(string stuId)
    {
        foreach (Course course in Enum.GetValues(typeof(Course)))
        {
            if (Waitlist[course].Any(s => s.ID == stuId))
            {
                return $"Student with ID {stuId} is in the waitlist for {course} course.";
            }

            if (EnrolledStudents[course].Any(s => s.ID == stuId))
            {
                return $"Student with ID {stuId} is enrolled in {course} course.";
            }
        }

        return $"Student with ID {stuId} not found.";
    }

    public void EnrollNextStudent(Course course) => EnrolledStudents[course].Add(Waitlist[course].Dequeue());

    public List<Student> GetEnrolledStudentsByCourse(Course course) => EnrolledStudents[course];
}