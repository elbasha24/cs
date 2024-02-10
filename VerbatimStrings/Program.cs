// Verbatim Strings in C#

// Verbatim strings, denoted by the @ symbol before the opening double quote, offer a way to include special characters like backslashes directly into your string without needing escape sequences. This is useful for file paths, long strings with backslashes, and preserving line breaks.

// Here's a breakdown of verbatim strings:

//Code snippet


string verbatimString = @"This is a verbatim string
with line breaks and paths like C:\users\john\myfile.txt";
System.Console.WriteLine(verbatimString);


// Benefits:

//     No need for escape sequences (e.g., \\ for a single backslash).
//     Include line breaks directly without escaping.
//     Easier to read for long strings with special characters.

// Additional Notes:

//     The @ symbol itself is not part of the string.
//     You can include double quotes within a verbatim string using "".
//     Use single quotes inside verbatim strings normally (no need to escape).
//     Verbatim strings cannot be interpolated.

// Examples:

    // File path:

//Code snippet


// string filePath = @"C:\Users\John\Documents\MyFile.txt";
    // Preserving line breaks:
//Code snippet


string poem = @"Roses are red,
Violets are blue,
Verbatim strings
Are great for you!";
System.Console.WriteLine(poem);

    // Mixing quotes:

//Code snippet


string message = @"He said, ""Hello, world!""";
System.Console.WriteLine(message);


// Comparison with Regular Strings:
// Feature	    Regular String	Verbatim String
// Backslash	Needs escaping (\\)	No escaping needed
// Line breaks	Newline character (\n)	Preserved directly
// Double quotes	Escaped as \"	Can be included as ""
// Single quotes	Escaped as \'	No escaping needed
// Readability	Lower for special characters	Higher for complex paths/strings

/*

Verbatim Strings in C#

Verbatim strings in C# are a special type of string literal that allows you to include characters literally within the string, without needing to escape them. This is useful for strings containing special characters like backslashes, double quotes, or line breaks, where you want them to be interpreted literally instead of as escape sequences.

Here's how to use verbatim strings:

1. Syntax:

Verbatim strings are prefixed with the @ symbol, followed by double quotes:
Code snippet

string message = @"This is a verbatim string.
It includes \n newlines and \t tabs without escaping.";

Use code with caution. Learn more

2. Benefits:

    No escaping: You don't need to escape special characters like \n or \" inside the string.
    Multiline strings: You can easily create multiline strings without using string concatenation.
    Readability: Verbatim strings can improve readability for code that includes complex string content.

3. Example:
Code snippet

string filePath = @"C:\Users\John\Documents\myfile.txt"; // No need to escape backslashes

string html = @"<html>
<head>
<title>My Page</title>
</head>
<body>
<h1>Hello, world!</h1>
</body>
</html>"; // Includes newlines and tabs literally

Use code with caution. Learn more

4. Limitations:

    Verbatim strings cannot be interpolated (using $).
    The @ symbol itself cannot be included directly within a verbatim string.

5. Alternative:

For situations where you need to interpolate values within a verbatim string, you can use the $@" syntax:
Code snippet

string name = "John";
string greeting = $@"""Hello, {name}!"""; // Interpolate name while keeping double quo

*/