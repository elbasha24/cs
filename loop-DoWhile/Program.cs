// Here are 10 examples of do-while loops in :

// 1. Menu-driven program:


do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        // Handle each option here
    }
} while (choice != 3);


// 2. Password validation:


string password;
do
{
    Console.Write("Enter password: ");
    password = Console.ReadLine();
} while (password != "secret");
Console.WriteLine("Password accepted!");



// 3. Input validation with retry:


int age;
do
{
    Console.Write("Enter your age (non-negative): ");
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
} while (true);



// 4. Reading numbers until a sentinel value:


int number, sum = 0;
do
{
    Console.Write("Enter a number (enter 0 to stop): ");
    number = int.Parse(Console.ReadLine());
    sum += number;
} while (number != 0);
Console.WriteLine("Total sum: " + sum);



// 5. Guessing game with guaranteed first try:


Random random = new Random();
int secretNumber = random.Next(1, 101);
int guess;

do
{
    Console.Write("Guess a number between 1 and 100: ");
    guess = int.Parse(Console.ReadLine());
} while (guess != secretNumber);

Console.WriteLine("Congratulations! You guessed the number.");



// 6. Rolling a die until a specific number:


Random random = new Random();
int roll, target = 6;

do
{
    roll = random.Next(1, 7);
    Console.WriteLine("Rolled: " + roll);
} while (roll != target);

Console.WriteLine("You rolled a " + target + "!");



// 7. Reading a file until the end:


string filename = "data.txt";
StreamReader reader = new StreamReader(filename);
string line;

do
{
    line = reader.ReadLine();
    if (line != null)
    {
        Console.WriteLine(line);
    }
} while (line != null);

reader.Close();



// 8. Factorial calculation with at least one iteration:


int number = 5;  // Example number
int factorial = 1;

do
{
    factorial *= number;
    number--;
} while (number >= 1);

Console.WriteLine("Factorial: " + factorial);



// 9. Reversing a string:


string word = "hello";
string reversed = "";

int i = word.Length - 1;
do
{
    reversed += word[i];
    i--;
} while (i >= 0);

Console.WriteLine("Reversed word: " + reversed);



// 10. Simple calculator with a "repeat" option:


do
{
    // Perform calculations here

    Console.Write("Do you want to perform another calculation? (y/n) ");
    char repeat = Console.ReadLine().ToLower()[0];
} while (repeat == 'y');



// Here are 10 examples of do while loops in :

// 1. Basic counting loop:


int count = 0;
do
{
    Console.WriteLine(count);
    count++;
} while (count < 10);



2. User input validation:


int age;
do
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
} while (true);



// 3. Guessing game with minimum guesses:


Random random = new Random();
int secretNumber = random.Next(1, 101);
int guessCount = 0;
bool guessedCorrect = false;

do
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
} while (!guessedCorrect && guessCount < 5); // At least 5 guesses

if (guessedCorrect)
{
    Console.WriteLine("Congratulations! You guessed the number in " + guessCount + " tries.");
}
else
{
    Console.WriteLine("Sorry, you ran out of guesses. The number was: " + secretNumber);
}



// 4. Reading lines from a file until reaching a specific keyword:


string filename = "data.txt";
StreamReader reader = new StreamReader(filename);
string line;
bool foundKeyword = false;

do
{
    line = reader.ReadLine();
    if (line != null && line.Contains("keyword")) // Replace with your keyword
    {
        foundKeyword = true;
        break;
    }
} while (line != null);

if (foundKeyword)
{
    Console.WriteLine("Found the keyword in the file.");
}
else
{
    Console.WriteLine("Keyword not found in the file.");
}



// 5. Simulating a coin toss until getting heads:


Random random = new Random();
bool heads = false;
int flips = 0;

do
{
    flips++;
    heads = random.NextDouble() >= 0.5;
} while (!heads);

Console.WriteLine("It took " + flips + " flips to get heads.");



// 6. Checking for palindrome while ignoring case:


string word;
Console.Write("Enter a word: ");
word = Console.ReadLine().ToLower(); // Convert to lowercase

bool isPalindrome = true;
int i = 0;
int j = word.Length - 1;

do
{
    if (word[i] != word[j])
    {
        isPalindrome = false;
        break;
    }
    i++;
    j--;
} while (i < j);

if (isPalindrome)
{
    Console.WriteLine(word + " is a palindrome.");
}
else
{
    Console.WriteLine(word + " is not a palindrome.");
}



// 7. Calculating factorial until reaching a user-defined limit:


int number;
Console.Write("Enter a non-negative integer: ");
number = int.Parse(Console.ReadLine());

int factorial = 1;
int counter = 1;

do
{
    factorial *= counter;
    counter++;
} while (counter <= number && factorial <= int.MaxValue); // Check for overflow

Console.WriteLine("The factorial of " + number + " is: " + factorial);



// Here are 10 examples of do while loops in :

// 1. Basic counting loop:


int count = 0;
do
{
    Console.WriteLine(count);
    count++;
} while (count < 10);



// 2. User input validation:


string name;
do
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
} while (string.IsNullOrEmpty(name));
Console.WriteLine("Hello, " + name + "!");



// 3. Password verification:


string password;
do
{
    Console.Write("Enter your password: ");
    password = Console.ReadLine();
} while (password.Length < 8);
Console.WriteLine("Password accepted.");



// 4. Reading lines from a file:


string filename = "data.txt";
StreamReader reader = new StreamReader(filename);
string line;
do
{
    line = reader.ReadLine();
    if (line != null)
    {
        Console.WriteLine(line);
    }
} while (line != null);
reader.Close();



// 5. Simulating a coin toss:


Random random = new Random();
bool heads = false;
int flips = 0;
do
{
    flips++;
    heads = random.NextDouble() >= 0.5;
} while (!heads);
Console.WriteLine("It took " + flips + " flips to get heads.");



// 6. Finding the smallest number in an array:


int[] numbers = { 10, 5, 20, 15, 30 };
int smallest = numbers[0];
int i = 1;
do
{
    if (numbers[i] < smallest)
    {
        smallest = numbers[i];
    }
    i++;
} while (i < numbers.Length);
Console.WriteLine("The smallest number is: " + smallest);



// 7. Checking for palindrome:


string word;
do
{
    Console.Write("Enter a word: ");
    word = Console.ReadLine();
} while (string.IsNullOrEmpty(word));

bool isPalindrome = true;
int i = 0;
int j = word.Length - 1;
do
{
    if (word[i] != word[j])
    {
        isPalindrome = false;
        break;
    }
    i++;
    j--;
} while (i < j);

if (isPalindrome)
{
    Console.WriteLine(word + " is a palindrome.");
}
else
{
    Console.WriteLine(word + " is not a palindrome.");
}



// 8. Simple menu-driven program:


int choice;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Perform Option 1 operations
            break;
        case 2:
            // Perform Option 2 operations
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Invalid choice.");
    }
} while (choice != 3);



// 9. Playing a simple guessing game:


Random random = new Random();
int secretNumber = random.Next(1, 101);
int guess;
do
{
    Console.Write("Guess a number between 1 and 100: ");
    guess = int.Parse(Console.ReadLine());
    if (guess == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed the number.");
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Your guess is too low. Try again.");
    }
    else
    {
        Console.WriteLine("Your guess is too high. Try again.");
    }
} while (guess != secretNumber);

// Here are 10 examples of do while loops in :

// 1. Basic counting loop:


int count = 0;
do
{
    Console.WriteLine(count);
    count++;
} while (count < 10);



// 2. User input validation:


int age;
do
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
} while (true);



3. Guessing game with minimum guesses:


Random random = new Random();
int secretNumber = random.Next(1, 101);
int guessCount = 0;
bool guessedCorrect = false;

do
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
} while (!guessedCorrect && guessCount < 5); // At least 5 guesses

if (guessedCorrect)
{
    Console.WriteLine("Congratulations! You guessed the number in " + guessCount + " tries.");
}
else
{
    Console.WriteLine("Sorry, you ran out of guesses. The number was: " + secretNumber);
}



// 4. Reading lines from a file until reaching a specific keyword:


// string filename = "data.txt";
// StreamReader reader = new StreamReader(filename);
// string line;
// bool foundKeyword = false;

// do
// {
//     line = reader.ReadLine();
//     if (line != null && line.Contains("keyword")) // Replace with your keyword
//     {
//         foundKeyword = true;
//         break;
//     }
// } while (line != null);

// if (foundKeyword)
// {
//     Console.WriteLine("Found the keyword in the file.");
// }
// else
// {
//     Console.WriteLine("Keyword not found in the file.");
// }



// 5. Simulating a coin toss until getting heads:


Random random = new Random();
bool heads = false;
int flips = 0;

do
{
    flips++;
    heads = random.NextDouble() >= 0.5;
} while (!heads);

Console.WriteLine("It took " + flips + " flips to get heads.");



// 6. Checking for palindrome while ignoring case:


string word;
Console.Write("Enter a word: ");
word = Console.ReadLine().ToLower(); // Convert to lowercase

bool isPalindrome = true;
int i = 0;
int j = word.Length - 1;

do
{
    if (word[i] != word[j])
    {
        isPalindrome = false;
        break;
    }
    i++;
    j--;
} while (i < j);

if (isPalindrome)
{
    Console.WriteLine(word + " is a palindrome.");
}
else
{
    Console.WriteLine(word + " is not a palindrome.");
}



// 7. Calculating factorial until reaching a user-defined limit:


int number;
Console.Write("Enter a non-negative integer: ");
number = int.Parse(Console.ReadLine());

int factorial = 1;
int counter = 1;

do
{
    factorial *= counter;
    counter++;
} while (counter <= number && factorial <= int.MaxValue); // Check for overflow

Console.WriteLine("The factorial of " + number + " is: " + factorial);



// 8. Menu-driven program with loop:


bool exit = false;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Exit");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Perform actions for Option 1
            break;
        case 2:
            // Perform actions for Option 2
            break;
        case 3:
            exit = true;  // Set exit flag to break the loop
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
} while (!exit);


do
{
    // Perform calculations here

    Console.Write("Do you want to perform another calculation? (y/n) ");
    char repeat = Console.ReadLine().ToLower()[0];

    if (repeat != 'y' && repeat != 'n')
    {
        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
    }
} while (repeat == 'y');


