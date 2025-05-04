namespace EducationExample;

public class Student(string name) : Person(name)
{
    public override void PrintInfo()
    {
        Console.WriteLine($"Student: {Name}");
    }
}