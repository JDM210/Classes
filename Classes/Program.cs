public class Person
{
    public Person()
    {
        Name = "Josh";
    }

    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; }

    
    public override string ToString()
    {
        return Name;
    }
}
class TestPerson
{
    private static void Main()
    {
  
        var person1 = new Person();
        Console.WriteLine(person1.Name);

        
        var person2 = new Person("Abbey");
        Console.WriteLine(person2.Name);
      
        Console.WriteLine(person1);
    }
}


