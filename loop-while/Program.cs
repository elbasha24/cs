// Here are 10 sample codes of while loops in  demonstrating different functionalities:

// 1. Basic counting:

int count = 0;
while (count < 10)
{
    Console.WriteLine(count);
    count++;
}


// 2. Iterating over an array:


string[] names = { "Alice", "Bob", "Charlie" };
int index = 0;
while (index < names.Length)
{
    Console.WriteLine(names[index]);
    index++;
}


// 3. User input validation:


int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
}
Console.WriteLine("You entered: " + number);


4. Reading lines from a file:


string line;
using (StreamReader reader = new StreamReader("myfile.txt"))
{
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}


// 5. Infinite loop (with break):


while (true)
{
    Console.WriteLine("This is an infinite loop! Press 'q' to quit.");
    if (Console.ReadKey().KeyChar == 'q')
    {
        break;
    }
}


// 6. Using a flag variable:


bool found = false;
int searchValue = 10;
int[] numbers = { 1, 5, 3, 8, 10, 2 };
int i = 0;
while (i < numbers.Length && !found)
{
    if (numbers[i] == searchValue)
    {
        found = true;
        Console.WriteLine("Value found at index: " + i);
    }
    i++;
}


// 7. Nested loops:


int rows = 3;
int columns = 4;
int i = 0;
while (i < rows)
{
    int j = 0;
    while (j < columns)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}


// 8. Menu program:


string choice;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Exit");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Option 1 code
            break;
        case "2":
            // Option 2 code
            break;
        case "3":
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
} while (choice != "3");


// 9. Calculating factorial:


int number = 5;
int result = 1;
int i = 1;
while (i <= number)
{
    result *= i;
    i++;
}
Console.WriteLine("Factorial of " + number + ": " + result);


// 10. Password guessing game:


string secretPassword = "password123";
string guess;
int attempts = 3;

while (attempts > 0)
{
    Console.Write("Enter password (remaining attempts: {0}): ", attempts);
    guess = Console.ReadLine();

    if (guess == secretPassword)
    {
        Console.WriteLine("Congratulations, you guessed the password!");
        break;
    }
    else
    {
        Console.WriteLine("Incorrect password. Try again.");
        attempts--;
    }
}

if (attempts == 0)
{
    Console.WriteLine("Sorry, you ran out of attempts.");
}


// These examples showcase the versatility of while loops and their wide range of applications in . Choose the appropriate loop structure based on your specific programming needs.


int count = 0;
while (count < 10)
{
    Console.WriteLine(count);
    count++;
}


// 2. User input validation:

int age;
while (true)
{
    Console.Write("Enter your age: ");
    try
    {
        age = int.Parse(Console.ReadLine());
        if (age >= 0)
        {
            break;
        }
    }
    catch (FormatException)
    {
        // Handle invalid input
    }
    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
}
Console.WriteLine("Your age is: " + age);


// 3. Guessing game:

Random random = new Random();
int secretNumber = random.Next(1, 101);
int guessCount = 0;
bool guessedCorrect = false;
while (!guessedCorrect)
{
    Console.Write("Guess a number between 1 and 100: ");
    int guess = int.Parse(Console.ReadLine());
    guessCount++;
    if (guess == secretNumber)
    {
        guessedCorrect = true;
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Your guess is too low.");
    }
    else
    {
        Console.WriteLine("Your guess is too high.");
    }
}
Console.WriteLine("Congratulations! You guessed the number in " + guessCount + " tries.");


// 4. Reading lines from a file:

string filename = "data.txt";
StreamReader reader = new StreamReader(filename);
string line;
while ((line = reader.ReadLine()) != null)
{
    Console.WriteLine(line);
}
reader.Close();


// 5. Calculating factorial:

int number;
Console.Write("Enter a non-negative integer: ");
number = int.Parse(Console.ReadLine());

int factorial = 1;
int counter = 1;
while (counter <= number)
{
    factorial *= counter;
    counter++;
}
Console.WriteLine("The factorial of " + number + " is: " + factorial);


// 6. Printing Fibonacci sequence:

int n;
Console.Write("Enter the number of terms: ");
n = int.Parse(Console.ReadLine());

int a = 0, b = 1, c;
int counter = 0;
while (counter < n)
{
    Console.Write(a + " ");
    c = a + b;
    a = b;
    b = c;
    counter++;
}


// 7. Simulating a coin toss:

Random random = new Random();
bool heads = false;
int flips = 0;
while (!heads)
{
    flips++;
    heads = random.NextDouble() >= 0.5;
}
Console.WriteLine("It took " + flips + " flips to get heads.");


8. Finding the largest number in an array:

int[] numbers = { 10, 5, 20, 15, 30 };
int largest = numbers[0];
int i = 1;
while (i < numbers.Length)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }
    i++;
}
Console.WriteLine("The largest number is: " + largest);


// 9. Checking for palindrome:

string word;
Console.Write("Enter a word: ");
word = Console.ReadLine();

bool isPalindrome = true;
int i = 0;
int j = word.Length - 1;
while (i < j)
{
    if (word[i] != word[j])
    {
        isPalindrome = false;
        break;
    }
    i++;
    j--;
}

if (isPalindrome)
{
    Console.WriteLine(word + " is a palindrome.");
}
else
{
    Console.WriteLine(word + " is not a palindrome.");
}


double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /): ");
char op = Convert.ToChar(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch (op)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    // ... add other operators
}

Console.WriteLine("The result is: " + result);

//Scenario 2: Guessing Game

string guess;
Random random = new Random();
int secretNumber = random.Next(1, 101); // Adjust range as needed

while (true)
{
    Console.Write("Enter first number: ");
    guess = Console.ReadLine();

    try
    {
        int guessedNumber = int.Parse(guess);
        if (guessedNumber == secretNumber)
        {
            Console.WriteLine("Congratulations! You guessed the number.");
            break;
        }
        else if (guessedNumber < secretNumber)
        {
            Console.WriteLine("Your guess is too low. Try again.");
        }
        else
        {
            Console.WriteLine("Your guess is too high. Try again.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}
