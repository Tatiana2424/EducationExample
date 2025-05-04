using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationExample;

public abstract class Person(string name)
{
    public string Name { get; } = name;

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}