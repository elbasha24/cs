// Here are 10 C# examples demonstrating formatted output:

// 1. Placeholders for string interpolation:


string name = "Alice";
int age = 30;
Console.WriteLine($"Hello, {name}! You are {age} years old.");

Use code with caution. Learn more

ing:
// C#

string formattedPrice = String.Format("Price: {0:C}", 123.45);
Console.WriteLine(formattedPrice); // Output: Price: $123.45

Use code with caution. Learn more

// C#

int x = 10, y = 20;
Console.WriteLine("X = {0}, Y = {1}", x, y);

Use code with caution. Learn more

// 4. Alignment and padding for columns:


Console.WriteLine("{0,-10} | {1,10}", "Name", "Age");
Console.WriteLine("{0,-10} | {1,10}", "John", 25);
Console.WriteLine("{0,-10} | {1,10}", "Alice", 30);



// 5. Number formatting with custom format strings:


double pi = 3.1415926535;
Console.WriteLine("PI (2 decimals): {0:0.00}", pi);
Console.WriteLine("PI (scientific notation): {0:E}", pi);


// 6. Date and time formatting:


DateTime now = DateTime.Now;
Console.WriteLine("Current date: {0:d}", now);
Console.WriteLine("Current time: {0:t}", now);


// 7. Padding with spaces or zeros:


int number = 123;
Console.WriteLine("Number (spaces): {0,5}", number); // Output: "  123"
Console.WriteLine("Number (zeros): {0,5:D5}", number); // Output: "00123"



// 8. Conditional output with string interpolation:


int score = 85;
Console.WriteLine($"Grade: {score >= 90 ? "A" : "B"}");



// 9. Custom numeric format strings for currency, percentages, etc.:

decimal price = 1234.56m;
Console.WriteLine("Price: {0:C}", price); // Output: $1,234.56
Console.WriteLine("Discount: {0:P2}", 0.25); // Output: 25.00%


// 10. Formatting for StringBuilder:

StringBuilder sb = new StringBuilder();
sb.AppendFormat("Hello, {0}!", "World");
Console.WriteLine(sb.ToString());

// Use code with caution. Learn more
//  C# provides various formatting options to control how data is presented in the console or 
// other output streams. Choose the appropriate methods and format strings based on your specific formatting needs.