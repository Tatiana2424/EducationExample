namespace EducationExample;

public class Course
{
    public string Title { get; }
    public Teacher Instructor { get; }

    private readonly List<Student> _students = [];

    public Course(string title, Teacher instructor)
    {
        Title = title;
        Instructor = instructor;
        Instructor.AssignCourse(this);
    }

    public void EnrollStudent(Student student)
    {
        _students.Add(student);
    }

    public List<Student> GetStudents()
    {
        return new List<Student>(_students);
    }

    public void PrintCourseInfo()
    {
        Console.WriteLine($"\nCourse: {Title}");
        Console.WriteLine($"Instructor: {Instructor.Name}");
        Console.WriteLine("Enrolled students:");
        foreach (var student in _students)
        {
            Console.WriteLine($" - {student.Name}");
        }
    }
}