10 Examples of For Loops in #

// For loops are one of the most fundamental control flow constructs in , offering a precise way to repeat a block of code a certain number of times. Here are 10 examples demonstrating their versatility:

// 1. Basic Iteration:

// Print numbers from 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// 2. Counting Down:
// Count down from 10 to 1
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

// 3. Skipping Values:

// Print even numbers from 2 to 20
for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}



// 4. Iterating over an Array:


int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// 5. Nested Loops:
// Print a multiplication table
for (int i = 1; i <= 12; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}

// 6. Iterating over Strings:
string name = "Alice";
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

// 7. Infinite Loop (Avoid Unless Intentional):
// This loop will run forever! Be careful.
for (; ; )
{
    // Code here
}



// 8. Early Termination with break:
// Print numbers until 5 is found
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

// 9. Conditional Iteration with continue:
// Print even numbers from 2 to 20 (exclude multiples of 3)
for (int i = 2; i <= 20; i += 2)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

// 10. Iterating with Generics:
List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // Prints 0, 1, 2, 3, 4
}

// 2. Iteration with a specific range:
for (int j = 10; j >= 0; j -= 2)
{
    Console.WriteLine(j); // Prints 10, 8, 6, 4, 2, 0
}

// 3. Looping through an array:
string[] names = { "Alice", "Bob", "Charlie" };
for (int k = 0; k < names.Length; k++)
{
    Console.WriteLine(names[k]); // Prints "Alice", "Bob", "Charlie"
}

// 4. Nested loops for 2D arrays:
int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
for (int m = 0; m < 2; m++)
{
    for (int n = 0; n < 3; n++)
    {
        Console.Write(matrix[m, n] + " "); // Prints "1 2 3 4 5 6 "
    }
    Console.WriteLine();
}
// 5. Using break to exit the loop early:
for (int p = 0; p < 10; p++)
{
    if (p == 5)
    {
        break;
    }
    Console.WriteLine(p); // Prints 0, 1, 2, 3, 4
}
// 6. Using continue to skip an iteration:
for (int q = 0; q < 10; q++)
{
    if (q % 2 == 0)
    {
        continue; // Skips even numbers
    }
    Console.WriteLine(q); // Prints 1, 3, 5, 7, 9
}
// 7. Infinite loop (use with caution):
for (; ; )
{
    // Code that runs indefinitely
    // ...
}
// 8. Looping through collections with foreach:
List<string> cities = new List<string>() { "New York", "London", "Paris" };
foreach (string city in cities)
{
    Console.WriteLine(city); // Prints "New York", "London", "Paris"
}
// 9. Using for loop for iterating over key-value pairs in dictionaries:
Dictionary<string, int> ages = new Dictionary<string, int>() { { "Alice", 30 }, { "Bob", 25 } };
foreach (KeyValuePair<string, int> entry in ages)
{
    Console.WriteLine($"{entry.Key} is {entry.Value} years old.");
}
// 10. Using for loop for iterating over characters in a string:
string message = "Hello, world!";
for (int r = 0; r < message.Length; r++)
{
    Console.Write(message[r]); // Prints "Hello, world!"
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}
// 2. Counting down:
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

// 3. Iterating over an array:
string[] names = { "Alice", "Bob", "Charlie" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Name: " + names[i]);
}

// 4. Using a flag variable:
bool searchFound = false;
for (int i = 0; i < 10 && !searchFound; i++)
{
    if (numbers[i] == targetValue)
    {
        searchFound = true;
        Console.WriteLine("Found value at index: " + i);
    }
}

// 5. Nested loops:
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(i + "," + j + " ");
    }
    Console.WriteLine();
}
// 6. Using break and continue:
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break; // Exit the loop early
    }
    if (i % 2 == 0)
    {
        continue; // Skip even numbers
    }
    Console.WriteLine(i);
}
// 7. Iterating over collections:
List<string> colors = new List<string>() { "Red", "Green", "Blue" };
foreach (string color in colors)
{
    Console.WriteLine(color);
}
// 8. Using for-each with arrays:
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
// 9. Using for-each with dictionaries:
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("Alice", 30);
ages.Add("Bob", 25);
foreach (KeyValuePair<string, int> entry in ages)
{
    Console.WriteLine(entry.Key + ": " + entry.Value);
}
// 10. Using for-each with custom iterators:
class MyEnumerable
{
    int[] values;
    int index = 0;

    public MyEnumerable(int[] values)
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

MyEnumerable myEnumerable = new MyEnumerable(new int[] { 1, 2, 3 });
foreach (int value in myEnumerable)
{
    Console.WriteLine(value);
}
