namespace EducationExample;

public class Teacher(string name) : Person(name)
{
    private readonly List<Course> _courses = [];

    public void AssignCourse(Course course)
    {
        _courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return new List<Course>(_courses);
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Teacher: {Name}");
    }
}