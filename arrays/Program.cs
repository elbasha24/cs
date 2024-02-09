// . Declaring and initializing an array:
int[] ages = new int[] { 25, 30, 22, 18 };
// Accessing elements by index:
string[] names = { "John", "Jane", "Alice" };
Console.WriteLine(names[1]); // Outputs "Jane"
//  Iterating over an array using a loop:
double[] prices = { 10.99, 5.25, 19.87 };
foreach (double price in prices)
{
    Console.WriteLine(price);
}

//  Finding the length of an array:

char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
int vowelCount = vowels.Length;
Console.WriteLine("Number of vowels: " + vowelCount);

// Finding the maximum element in an array:
int[] numbers = { 7, 12, 3, 18 };
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine("Maximum element: " + max);


// Reversing an array:

string[] words = { "apple", "banana", "cherry" };
Array.Reverse(words);
foreach (string word in words)
{
    Console.WriteLine(word);
}


// Sorting an array:

int[] scores = { 90, 85, 78, 95 };
Array.Sort(scores);
for (int i = 0; i < scores.Length; i++)
{
    Console.Write(scores[i] + " ");
}

//  Searching for an element in an array:

string[] cities = { "London", "Paris", "New York", "Tokyo" };
bool found = Array.IndexOf(cities, "Tokyo") >= 0;
Console.WriteLine("Tokyo found: " + found);


// Multidimensional arrays:

int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine(matrix[2, 1]); // Outputs 8

//  Jagged arrays (arrays of arrays):

string[][] students = new string[3][];
students[0] = new string[] { "Alice", "Bob" };
students[1] = new string[] { "Charlie", "David" };
students[2] = new string[] { "Emily" };
foreach (string[] group in students)
{
    foreach (string name in group)
    {
        Console.Write(name + " ");
    }
    Console.WriteLine();
}
