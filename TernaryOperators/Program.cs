

1.Simple Assignment:
////Code snippet

bool isHappy = true;
string message = isHappy ? "I'm happy!" : "I'm not happy.";
Console.WriteLine(message); // Outputs "I'm happy!"

// 2. Comparing Numbers:
////Code snippet

int num1 = 10;
int num2 = 5;
int larger = num1 > num2 ? num1 : num2;
Console.WriteLine(larger); // Outputs 10

// 3. Checking Null Values:
////Code snippet

string name = null;
string greeting = name != null ? $"Hello, {name}!" : "Hello, there!";
Console.WriteLine(greeting); // Outputs "Hello, there!"

// 4. Calculating with Conditions:
////Code snippet

double price = 20.0;
double discount = 0.1;
double finalPrice = price > 15.0 ? price * (1 - discount) : price;
Console.WriteLine(finalPrice); // Outputs 18.0

// 5. Nested Ternary Operators:
////Code snippet

int grade = 85;
string result = grade >= 90 ? "Excellent!" : (grade >= 80 ? "Good" : "Needs improvement");
Console.WriteLine(result); // Outputs "Good"

// 6. Combining with Logical Operators:
////Code snippet

bool isMale = true;
int age = 25;
string access = isMale && (age >= 18) ? "Granted" : "Denied";
Console.WriteLine(access); // Outputs "Granted"

// 7. Returning from Functions:
////Code snippet

bool isValidInput(string input)
{
    return input.Length > 0 ? true : false;
}

// 8. Conditional String Formatting:
////Code snippet

string color = "red";
string message = $"The color is {color}{(color == "red" ? "!" : "?")}";
Console.WriteLine(message); // Outputs "The color is red!"

// 9. Using Ternary as Alternative to If-Else:
////Code snippet

int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

// Ternary equivalent
Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");


// 10. Combining with Null-Conditional Operator:
////Code snippet

Person person = null;
string name = person?.Name ?? "Unknown"; // Gets Name if person is not null, otherwise "Unknown"
Console.WriteLine(name); // Outputs "Unknown"

// Simple assignment based on condition:

//Code snippet

int age = 25;
bool isAdult = age >= 18 ? true : false;
Console.WriteLine(isAdult); // Output: True

// Shortened if-else statement:

//Code snippet

string message = grade >= 90 ? "Excellent!" : "Keep practicing!";
Console.WriteLine(message); // Output: Excellent! (assuming grade is 95)

// Returning different values based on condition:

//Code snippet

double price = 10.0;
double discount = 0.1;
double finalPrice = price > 20.0 ? price * (1 - discount) : price;
Console.WriteLine(finalPrice); // Output: 10.0 (price not exceeding 20.0)

// Conditional null assignment:

//Code snippet

string name = null;
string greeting = name ?? "Stranger";
Console.WriteLine(greeting); // Output: Stranger (name is null)

// Chaining ternary operators:

//Code snippet

int number = 5;
string result = number % 2 == 0 ? "Even" : (number % 3 == 0 ? "Divisible by 3" : "Odd");
Console.WriteLine(result); // Output: Odd

// Using ternary operators in loops:

//Code snippet

int[] numbers = { 1, 2, 3, 4, 5 };
string evenNumbers = "";
foreach (int num in numbers)
{
    evenNumbers += num % 2 == 0 ? num + " " : "";
}
Console.WriteLine(evenNumbers); // Output: 2 4

// Checking for null values:

//Code snippet

string input = Console.ReadLine();
int value = int.TryParse(input, out int parsedValue) ? parsedValue : 0;
Console.WriteLine(value); // Converts input to integer or defaults to 0 if invalid

// Determining truthiness in expressions:

//Code snippet

bool isEmpty = string.IsNullOrEmpty(text) ? true : false;
Console.WriteLine(isEmpty); // True if text is null or empty

// Nested ternary operators for complex logic:

//Code snippet

int score = 85;
string grade = score >= 90 ? "A" : (score >= 80 ? "B" : (score >= 70 ? "C" : "D"));
Console.WriteLine(grade); // Output: B

// Using ternary operators for readability (subjective):

//Code snippet

string result = (isCompleted) ? "Success!" : "Error";
Console.WriteLine(result);

// Ternary operators, also known as conditional expressions, offer a concise way to write simple if-else statements in a single line. Here are 10 examples showcasing their versatility in :

// 1. Basic example:


int age = 25;
string message = age >= 18 ? "Adult" : "Minor"; // "Adult"

// 2. Assigning values based on conditions:
double grade = 87.5;
char letterGrade = grade >= 90 ? 'A' : (grade >= 80 ? 'B' : 'C'); // 'B'

// 3. Short-circuiting:
bool hasPermission = true;
string permissionMessage = hasPermission ? "You have access." : null; // "You have access."
// 4. Nested ternaries:

int number = 10;
string parity = number % 2 == 0 ? "Even" : (number > 0 ? "Positive Odd" : "Negative Odd"); // "Positive Odd"

// 5. Returning values from functions:

int max(int a, int b) => a > b ? a : b; // Returns the larger value

// 6. Checking null values:

string name = null;
string greeting = name != null ? $"Hello, {name}!" : "Hello!"; // "Hello!"

// 7. Using with logical operators:
bool isStudent = true;
bool isTeacher = false;
string role = isStudent && isTeacher ? "Both Student and Teacher" : (isStudent ? "Student" : (isTeacher ? "Teacher" : "None")); // "Student"

// 8. Ternary operators with strings:

string country = "USA";
string language = country == "USA" ? "English" : (country == "France" ? "French" : "Spanish"); // "English"

// 9. Using constants:
const int MAX_VALUE = 100;
int value = 120;
string result = value <= MAX_VALUE ? "Within limit" : "Exceeds limit"; // "Exceeds limit"

// 10. Early termination with ternary:
int counter = 0;
while (counter < 10)
{
    if (counter == 5)
    {
        break; // Early termination with break
    }
    Console.WriteLine(counter++);
}

int counter = 0;
while (counter < 10 && counter != 5) // Using ternary for early exit
{
    Console.WriteLine(counter++);
}


