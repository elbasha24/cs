internal class Program
{
    private static void Main(string[] args)
    {
        Here are 10 examples of how "T" is used as a type parameter in generics within C#:

// 1. Generic List:

// List can hold any type of elements
List<int> numbers = new List<int>() { 1, 2, 3 };
        List<string> names = new List<string>() { "Alice", "Bob" };

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        

// 2. Generic Dictionary:
// Dictionary can store key-value pairs of any type
Dictionary<string, int> ages = new Dictionary<string, int>() { { "Alice", 30 }, { "Bob", 25 } };

        string name = "Alice";
        if (ages.ContainsKey(name))
        {
            Console.WriteLine($"{name} is {ages[name]} years old.");
        }

    
// 3. Generic Interface:

List<Person> people = new List<Person>() { new Person { Name = "John", Age = 30 }, new Person { Name = "Alice", Age = 25 } };
        people.Sort(); // Sorts people by name using IComparable

        foreach (Person person in people)
        {
            Console.WriteLine(person.Name);
        }

        

// 4. Generic Method:

T Add<T>(T value1, T value2) where T : 
int sum = Add(5, 2);
        Console.WriteLine(sum);

        // Double addition won't work due to constraint
        // double num = Add(3.14, 2.5);

// 5. Generic Delegate:

Func<int, int, int> addFunction = (a, b) => a + b;
        int result = addFunction(10, 5);
        Console.WriteLine(result);

        Func<string, string> greetFunction = (name) => "Hello, " + name + "!";
        string greeting = greetFunction("Bob");
        Console.WriteLine(greeting);

// 6. Custom Generic Class:


Pair<int, string> numberPair = new Pair<int, string>(1, "one");
        Console.WriteLine($"Pair: ({numberPair.First}, {numberPair.Second})");

// 7. Using Constraints:

MyComparer<string> stringComparer = new MyComparer<string>();
        bool isGreater = stringComparer.Compare("A", "B");
        Console.WriteLine(isGreater); // False

// 8. Nested Generics:

Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
        data["fruits"] = new List<int>() { 1, 2, 3 };
        data["vegetables"] = new List<int>() { 4, 5, 6 };

        foreach (KeyValuePair<string, List<int>> entry in data)
        {
            Console.WriteLine(entry.Key + ": " + string.Join(",", entry.Value));
        }     

// 9. Generic Interfaces with Multiple Parameters:

}
}

interface IComparable<T>
{
    int CompareTo(T other);
}

class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        return Name.CompareTo(other.Name);
    }
}

struct
{
    return value1 + value2; // Only works with value types
}

class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}

class MyComparer<T> where T : IComparable<T>
{
    public bool Compare(T value1, T value2)
    {
        return value1.CompareTo(value2) > 0;
    }
}

interface IRepository<T, K> where T : class
{
    T GetById(K id);
    void Add(T entity);
}

class UserRepository : IRepository<User, int>
{
    // Implementation for User and int
}

