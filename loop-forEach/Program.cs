// 10 Examples of foreach Loops in :#

// The foreach loop is a powerful construct in  that simplifies iterating over collections. Here are 10 examples showcasing its versatility:

// 1. Iterating over an array:


string[] names = { "Alice", "Bob", "Charlie" };
foreach (string name in names)
{
    Console.WriteLine("Hello, " + name + "!");
}


// 2. Working with lists:
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number + " is even.");
    }
    else
    {
        Console.WriteLine(number + " is odd.");
    }
}


// 3. Handling dictionaries:


Dictionary<string, string> cities = new Dictionary<string, string>()
{
    { "USA", "New York" },
    { "France", "Paris" },
    { "Italy", "Rome" }
};

foreach (KeyValuePair<string, string> entry in cities)
{
    Console.WriteLine("Country: {0}, Capital: {1}", entry.Key, entry.Value);
}


// 4. Using custom iterators:
class RangeIterator
{
    int start, end;
    int current;

    public RangeIterator(int start, int end)
    {
        this.start = start;
        this.end = end;
        this.current = start;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        return current < end;
    }

    public int Current => current++;
}

foreach (int number in new RangeIterator(1, 10))
{
    Console.Write(number + " ");
}


// 5. Accessing element indexes:


string[] colors = { "Red", "Green", "Blue" };
int counter = 0;
foreach (string color in colors)
{
    Console.WriteLine("Color index: " + counter + ", Color: " + color);
    counter++;
}


// 6. Filtering elements:


List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
foreach (int number in numbers.Where(n => n % 2 == 0))
{
    Console.Write(number + " "); // Print only even numbers
}


// 7. Modifying elements during iteration:


List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };
foreach (string name in names)
{
    if (name == "Bob")
    {
        name = "Robert"; // Change name in-place
    }
}


// 8. Breaking out of the loop:


List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    if (number == 4)
    {
        break; // Exit loop after finding 4
    }
    Console.WriteLine(number);
}


// 9. Combining with LINQ:


int[] numbers = { 2, 4, 6, 8, 10 };
IEnumerable<int> multiplesOfThree = numbers.Where(n => n % 3 == 0).Select(n => n * 2);
foreach (int number in multiplesOfThree)
{
    Console.WriteLine(number); // Print doubles of multiples of 3
}


// 10. Using with anonymous types:


List<object> data = new List<object>()
{
    new { Name = "Alice", Age = 30 },
    new { Name = "Bob", Age = 25 }
};

foreach (var item in data)
{
    Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
}

string[] words = { "hello", "world", "!" };
int index = 0;
foreach (string word in words)
{
    Console.WriteLine($"Word at index {index}: {word}");
    index++;
}


// Using break and continue with foreach:

List<string> colors = new List<string>() { "Red", "Green", "Blue", "Yellow" };
foreach (string color in colors)
{
    if (color == "Green")
    {
        continue; // Skip green
    }
    Console.WriteLine(color);
    if (color == "Yellow")
    {
        break; // Exit after Yellow
    }
}


// 6. Iterating over custom collections:

class MyCollection
{
    string[] items;
    int index = 0;

    public MyCollection(string[] items)
    {
        this.items = items;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        return index < items.Length;
    }

    public string Current => items[index++];
}

MyCollection myCollection = new MyCollection(new string[] { "a", "b", "c" });
foreach (string item in myCollection)
{
    Console.Write(item + " ");
}


// Using foreach with arrays and indexers:

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(numbers[Array.IndexOf(numbers, number)]); // Access by value
}


//  Iterating over a string:

string message = "Hello, world!";
foreach (char character in message)
{
    Console.Write(character + " ");
}


// Using foreach with lambda expressions:

List<int> values = new List<int>() { 1, 2, 3, 4, 5 };
values.ForEach(number => Console.WriteLine(number * 2)); // Apply lambda to each element


// 10. Using foreach with anonymous types:

var people = new[]
{
    new { Name = "Alice", Age = 30 },
    new { Name = "Bob", Age = 25 }
};
foreach (var person in people)
{
    Console.WriteLine($"{person.Name} is {person.Age} years old.");
}


//Accessing key-value pairs in a Dictionary<TKey, TValue>:

Dictionary<string, string> countries = new Dictionary<string, string>();
countries.Add("USA", "English");
countries.Add("France", "French");

foreach (KeyValuePair<string, string> entry in countries)
{
    Console.WriteLine(entry.Key + ": " + entry.Value);
}


// Iterating over custom collections:

class MyCollection
{
    public string[] items;
    public int index = 0;

    public MyCollection(string[] items)
    {
        this.items = items;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        return index < items.Length;
    }

    public string Current => items[index++];
}

MyCollection customCollection = new MyCollection(new string[] { "a", "b", "c" });
foreach (string item in customCollection)
{
    Console.WriteLine(item);
}

//Filtering elements during iteration (using if):

List<string> fruits = new List<string>() { "apple", "banana", "orange", "mango" };
foreach (string fruit in fruits)
{
    if (fruit.StartsWith("a"))
    {
        Console.WriteLine(fruit);
    }
}

//Breaking out of the loop early (using break):
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    if (number == 3)
    {
        break;
    }
    Console.WriteLine(number);
}

//Skipping specific elements (using continue):


List<string> names = new List<string>() { "Alice", "Bob", "Charlie", "David" };
foreach (string name in names)
{
    if (name == "Bob")
    {
        continue;
    }
    Console.WriteLine(name);
}


//Accessing indices with foreach:

string[] colors = new string[] { "red", "green", "blue" };
int index = 0;
foreach (string color in colors)
{
    Console.WriteLine($"Color at index {index}: {color}");
    index++;
}


//Using foreach with custom iterators:

class MySequence
{
    int[] values;
    int index = 0;

    public MySequence(int[] values)
    {
        this.values = values;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        return index < values.Length;
    }

    public int Current => values[index++];
}

MySequence mySequence = new MySequence(new int[] { 10, 20, 30 });
foreach (int value in mySequence)
{
    Console.WriteLine(value);
}

// Reversing the order of iteration (using Reverse()):
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
numbers.Reverse();  // Reverse the order of elements in the list
foreach (int number in numbers)
{
    Console.Write(number + " ");  // Print each number with a space
}
Console.WriteLine();  // Add a newline at the end




/*Remember that foreach is generally preferred over manual indexing loops when iterating over collections due to its cleaner syntax and ease of use. Choose the most appropriate approach based on your specific needs and coding style.*/ 