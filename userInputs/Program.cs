// Greeting with Name:
Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");

// Age Verification:

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Sorry, you must be 18 or older.");
}


//Simple Calculator:

Console.Write("Enter first number: ");
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
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero");
        }
        else
        {
            result = num1 / num2;
        }
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

if (result != 0) // Handle division by zero gracefully
{
    Console.WriteLine("Result: " + result);
}


// Guessing Game:

int secretNumber = new Random().Next(1, 101);
int guess = 0;
int attempts = 0;

Console.WriteLine("Guess a number between 1 and 100:");

while (guess != secretNumber)
{
    guess = Convert.ToInt32(Console.ReadLine());
    attempts++;

    if (guess < secretNumber)
    {
        Console.WriteLine("Too low, try again!");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high, try again!");
    }
}

Console.WriteLine("You guessed it in " + attempts + " attempts!");


// Rock-Paper-Scissors:

string[] choices = { "rock", "paper", "scissors" };
Random random = new Random();
string computerChoice = choices[random.Next(choices.Length)];

Console.Write("Enter your choice (rock, paper, scissors): ");
string userChoice = Console.ReadLine().ToLower();

if (!choices.Contains(userChoice))
{
    Console.WriteLine("Invalid choice.");
}
else
{
    Console.WriteLine("Computer chose: " + computerChoice);

    if (userChoice == computerChoice)
    {
        Console.WriteLine("Tie!");
    }
    else if ((userChoice == "rock" && computerChoice == "scissors") ||
             (userChoice == "paper" && computerChoice == "rock") ||
             (userChoice == "scissors" && computerChoice == "paper"))
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("You lose!");
    }
}


// Unit Converter:

Console.Write("Enter a number: ");
double value = Convert.ToDouble(Console.ReadLine());
Console.Write("Convert to (C)elsius or (F)ahrenheit? ");
char choice = Convert.ToChar(Console.ReadLine().ToUpper());

double result = 0;
switch (choice)
{
    case 'C':
        result = (value - 32) * 5 / 9;
        Console.WriteLine("{0}°F is equal to {1}°C", value, result);
        break;
    case 'F':
        result = (value * 9 / 5) + 32;
        Console.WriteLine("{0}°C is equal to {1}°F", value, result);
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}


// Simple Quiz:

string[] questions = { "What is the capital of France?", "What is the largest ocean on Earth?", "What is the currency of Japan?" };
string[] answers = { "Paris", "Pacific Ocean", "Yen" };
int score = 0;

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    string userAnswer = Console.ReadLine().ToLower();

    if (userAnswer == answers[i].ToLower())
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect. The answer is " + answers[i]);
    }
}

Console.WriteLine("Your final score is: " + score + " out of " + questions.Length);

