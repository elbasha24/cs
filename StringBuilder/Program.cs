// Here are 10 examples of using StringBuilder in C#:

// 1. Basic string concatenation:

string name = "Alice";
string greeting = "Hello, ";

StringBuilder builder = new StringBuilder();
builder.Append(greeting);
builder.Append(name);
builder.Append("!");

Console.WriteLine(builder.ToString()); // Output: Hello, Alice!



// 2. Efficiently joining strings:

List<string> words = new List<string>() { "quick", "brown", "fox" };

string joined = string.Join(" ", words); // Less efficient

StringBuilder builder = new StringBuilder();
for (int i = 0; i < words.Count; i++)
{
    builder.Append(words[i]);
    if (i < words.Count - 1)
    {
        builder.Append(" ");
    }
}

Console.WriteLine(builder.ToString()); // Output: quick brown fox



// 3. Modifying specific characters:

string text = "Welcome to Code!";

StringBuilder builder = new StringBuilder(text);
builder[0] = 'W'; // Change first character
builder.Insert(8, " the "); // Insert text at position 8

Console.WriteLine(builder.ToString()); // Output: Welcome to the Code!



// 4. Removing parts of a string:

string message = "The quick brown fox jumps over the lazy dog.";

StringBuilder builder = new StringBuilder(message);
builder.Remove(5, 9); // Remove "brown fox"

Console.WriteLine(builder.ToString()); // Output: The quick jumps over the lazy dog.



// 5. Reversing a string:
// 
string word = "hello";

StringBuilder builder = new StringBuilder(word);
builder.Reverse();

Console.WriteLine(builder.ToString()); // Output: olleh



// 6. Appending formatted strings:

int age = 30;
double price = 19.99;

StringBuilder builder = new StringBuilder();
builder.AppendFormat("Your age is {0} and the price is ${1:0.00}.", age, price);

Console.WriteLine(builder.ToString()); // Output: Your age is 30 and the price is $19.99.



// 7. Building HTML content:

StringBuilder html = new StringBuilder();
html.Append("<ul>");
html.Append("<li>Item 1</li>");
html.Append("<li>Item 2</li>");
html.Append("</ul>");

Console.WriteLine(html.ToString()); // Output: <ul><li>Item 1</li><li>Item 2</li></ul>



// 8. Thread-safe string concatenation:

List<Thread> threads = new List<Thread>();
StringBuilder sharedBuilder = new StringBuilder();

foreach (string word in words)
{
    threads.Add(new Thread(() => sharedBuilder.Append(word)));
}

foreach (Thread thread in threads)
{
    thread.Start();
}

foreach (Thread thread in threads)
{
    thread.Join();
}

Console.WriteLine(sharedBuilder.ToString()); // Output: (concatenated words)



// 9. Reading lines from a file and appending them:

// string filename = "data.txt";

// StringBuilder builder = new StringBuilder();
// string line;
// using (StreamReader reader = new StreamReader(filename))
// {
//     while ((line = reader.ReadLine()) != null)
//     {
//         builder.AppendLine(line);
//     }
// }

// Console.WriteLine(builder.ToString()); // Output: (contents of the file)



// 10. Combining multiple techniques:

string[] emails = { "user1@example.com", "user2@domain.com" };

StringBuilder message = new StringBuilder();
message.AppendLine("To:");
foreach (string email in emails)
{
    message.AppendLine(email);
}
message.AppendLine("Subject: Important update");
message.AppendLine("Body...");

Console.WriteLine(message.ToString()); // Output: formatted email message

string[] words2 = { "apple", "banana", "cherry" };
StringBuilder sb = new StringBuilder();
for (int i = 0; i < words2.Length; i++)
{
    sb.Append(words2[i]);
    if (i < words2.Length - 1)
    {
        sb.Append(", ");
    }
}
Console.WriteLine(sb.ToString()); // Output: apple, banana, cherry


// string text = "The quick brown fox jumps over the lazy dog.";
// StringBuilder sb = new StringBuilder(text);
// sb.Replace("fox", "cat");
// Console.WriteLine(sb.ToString()); // Output: The quick brown cat jumps over the lazy dog.


// Inserting text at a specific position:


// string sentence = "This is a sentence.";
// StringBuilder sb = new StringBuilder(sentence);
// sb.Insert(10, " very ");
// Console.WriteLine(sb.ToString()); // Output: This is a very sentence.


//  Removing characters from a string:

// string number = "1234567890";
// StringBuilder sb = new StringBuilder(number);
// sb.Remove(3, 4);
// Console.WriteLine(sb.ToString()); // Output: 1237890


//Checking for empty or null StringBuilder:

// StringBuilder sb = new StringBuilder();
// if (sb.Length == 0)
// {
//     Console.WriteLine("StringBuilder is empty.");
// }
// if (sb == null)
// {
//     Console.WriteLine("StringBuilder is null."); // This won't be triggered
// }


//Appending different data types:

// StringBuilder sb = new StringBuilder();
// sb.Append(10);
// sb.Append(" ");
// sb.Append(true);
// Console.WriteLine(sb.ToString()); // Output: 10 True


//Converting StringBuilder to a string:

// StringBuilder sb = new StringBuilder("Hello");
// string str = sb.ToString();
// Console.WriteLine(str); // Output: Hello


// // 10. Using StringBuilder with asynchronous operations:

// async Task AppendAsync()
// {
//     StringBuilder sb = new StringBuilder();
//     await Task.Run(() => sb.Append("Part 1"));
//     await Task.Run(() => sb.Append(" "));
//     await Task.Run(() => sb.Append("Part 2"));
//     Console.WriteLine(sb.ToString()); // Output: Part 1 Part 2
// }

/*Here are 10 examples of using StringBuilder in C#:

1. Basic string concatenation:
Code snippet

string str1 = "Hello";
string str2 = " World!";
StringBuilder builder = new StringBuilder();
builder.Append(str1);
builder.Append(str2);
string result = builder.ToString();
Console.WriteLine(result); // Output: Hello World!

Use code with caution. Learn more

2. Efficiently building a string with multiple appends:
Code snippet

string[] names = { "Alice", "Bob", "Charlie" };
StringBuilder builder = new StringBuilder();
for (int i = 0; i < names.Length; i++)
{
    builder.Append(names[i]);
    if (i < names.Length - 1)
    {
        builder.Append(", ");
    }
}
string commaSeparatedNames = builder.ToString();
Console.WriteLine(commaSeparatedNames); // Output: Alice, Bob, Charlie

Use code with caution. Learn more

3. String formatting with placeholders:
Code snippet

int age = 30;
string name = "John";
StringBuilder builder = new StringBuilder();
builder.AppendFormat("My name is {0} and I am {1} years old.", name, age);
string formattedString = builder.ToString();
Console.WriteLine(formattedString); // Output: My name is John and I am 30 years old.

Use code with caution. Learn more

4. Modifying string content after construction:
Code snippet

StringBuilder builder = new StringBuilder("This is a string.");
builder.Insert(10, " modified ");
builder.Replace("string", "sentence");
string modifiedString = builder.ToString();
Console.WriteLine(modifiedString); // Output: This is a modified sentence.

Use code with caution. Learn more

5. Removing specific characters from a string:
Code snippet

StringBuilder builder = new StringBuilder("Hello, world!");
builder.Remove(7, 7); // Remove the comma and space
string trimmedString = builder.ToString();
Console.WriteLine(trimmedString); // Output: Hello world!

Use code with caution. Learn more

6. Reversing a string:
Code snippet

StringBuilder builder = new StringBuilder("Hello");
builder.Reverse();
string reversedString = builder.ToString();
Console.WriteLine(reversedString); // Output: olleH

Use code with caution. Learn more

7. Converting string to uppercase/lowercase:
Code snippet

StringBuilder builder = new StringBuilder("Hello World!");
builder.ToStringUpper(); // ToUpper
builder.ToStringLower(); // ToLower
string convertedString = builder.ToString();
Console.WriteLine(convertedString); // Output: HELLO WORLD! in this case

Use code with caution. Learn more

8. Removing leading/trailing whitespace:
Code snippet

StringBuilder builder = new StringBuilder("   Hello World!   ");
builder.Trim();
string trimmedString = builder.ToString();
Console.WriteLine(trimmedString); // Output: Hello World!

Use code with caution. Learn more

9. Building a string with multiple lines:
Code snippet

StringBuilder builder = new StringBuilder();
builder.AppendLine("Line 1");
builder.AppendLine("Line 2");
builder.AppendLine("Line 3");
string multilineString = builder.ToString();
Console.WriteLine(multilineString);
// Output:
// Line 1
// Line 2
// Line 3

Use code with caution. Learn more

10. Using string builder for building HTML content:
Code snippet

StringBuilder builder = new StringBuilder();
builder.Append("<p>This is a paragraph.</p>");
builder.Append("<h2>This is a heading.</h2>");
string htmlContent = builder.ToString();
Console.WriteLine(htmlContent);
// Output:
// <p>This is a paragraph.</p>
// <h2>This is a heading.</h2>

Use code with caution. Learn more
*/