using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationExample;

public abstract class Person
{
    public string Name { get; }

    protected Person(string name)
    {
        Name = name;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}