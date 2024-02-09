// Simple Void Function: This function doesn't return anything.
void Greet(string name)
{
  Console.WriteLine("Hello, " + name + "!");
}

Greet("John"); // Output: Hello, John!


// // Function with Return Value: This function returns a string.

string FormatName(string firstName, string lastName)
{
  return firstName + " " + lastName;
}

string fullName = FormatName("Alice", "Smith");
Console.WriteLine(fullName); // Output: Alice Smith


// // Function with Parameters: This function takes two numbers and performs addition.

int Add(int num1, int num2)
{
  return num1 + num2;
}

int sum = Add(5, 3);
Console.WriteLine(sum); // Output: 8


// // Function with Default Parameter: This function has a default value for the second parameter.

void PrintMessage(string message, string greeting = "Hi")
{
  Console.WriteLine(greeting + ", " + message);
}

PrintMessage("Welcome!"); // Output: Hi, Welcome!
PrintMessage("How are you?", "Hello"); // Output: Hello, How are you?


// // Function with Optional Parameter: This function uses the params keyword for an optional array of strings.

void CombineNames(string firstName, params string[] middleNames)
{
  string fullName = firstName;
  foreach (string name in middleNames)
  {
    fullName += " " + name;
  }
  Console.WriteLine(fullName);
}

CombineNames("John", "Robert", "Michael"); // Output: John Robert Michael

// //Function Overloading: This code shows two functions with the same name but different parameter types.

// int Add(int num1, int num2) { return num1 + num2; }
// double Add(double num1, double num2) { return num1 + num2; }

// int numberSum = Add(10, 20);
// double doubleSum = Add(3.5, 2.1);
// Console.WriteLine(numberSum); // Output: 30
// Console.WriteLine(doubleSum); // Output: 5.6


// //Recursive Function: This function calculates the factorial of a number.

int Factorial(int n)
{
  if (n == 0)
  {
    return 1;
  }
  else
  {
    return n * Factorial(n - 1);
  }
}

int result = Factorial(5);
Console.WriteLine(result); // Output: 120


// //Lambda Function: This code demonstrates a simple lambda function for adding two numbers.

// Func<int, int, int> addFunction = (num1, num2) => num1 + num2;
// int sum = addFunction(7, 4);
// Console.WriteLine(sum); // Output: 11


// //Anonymous Function: This example uses an anonymous function to check if a number is even.

// bool isEven = delegate(int number) { return number % 2 == 0; };
// if (isEven(12))
// {
//   Console.WriteLine("12 is even.");
// }


// // Named Inner Function: This code defines a named inner function inside another function.

void OuterFunction()
{
  void InnerFunction()
  {
    Console.WriteLine("This is an inner function.");
  }
  InnerFunction();
}

OuterFunction(); // Output: This is an inner function.
