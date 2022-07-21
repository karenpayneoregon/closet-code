# Ignore suggestions 1

```csharp
public class BogusOperations
{
    public static List<Person> People(int count = 10)
    {
        int identifier = 1;
        // ReSharper disable All
        Faker<Person> fakePerson = new Faker<Person>()
                .CustomInstantiator(f => new Person(identifier++))
                .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                .RuleFor(p => p.LastName, f => f.Person.LastName)
                .RuleFor(p => p.BirthDate, f => f.Date.Past(10))
            ;

        // ReSharper restore All
        return fakePerson.Generate(count);

    }
}
```

# Ignore suggestions 2

```csharp
public class BogusOperations
{
    [SuppressMessage("ReSharper", "All")]
    public static List<Person> People(int count = 10)
    {
        int identifier = 1;
        
        Faker<Person> fakePerson = new Faker<Person>()
                .CustomInstantiator(f => new Person(identifier++))
                .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                .RuleFor(p => p.LastName, f => f.Person.LastName)
                .RuleFor(p => p.BirthDate, f => f.Date.Past(10))
            ;

       
        return fakePerson.Generate(count);

    }
}
```