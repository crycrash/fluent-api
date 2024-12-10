using System.Diagnostics.Contracts;

namespace ObjectPrintingHomework;

public class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }
    public int CountEyes { get; set; }
    public string Surname { get; set; }
    public DateTime DateBirth {get; set; }
}