//Printing Fibonacci sequence:
int n = 10;
int a = 0, b = 1, c;
Console.WriteLine("Fibonacci Series:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);
    c = a + b;
    a = b;
    b = c;
}
// Checking if a number is prime:
int num = 13;
bool isPrime = true;
for (int i = 2; i <= Math.Sqrt(num); i++)
{
    if (num % i == 0)
    {
        isPrime = false;
        break;
    }
}
Console.WriteLine(num + " is prime: " + isPrime);

// Reversing a string:
string word = "Hello";
string reversed = "";
for (int i = word.Length - 1; i >= 0; i--)
{
    reversed += word[i];
}
Console.WriteLine("Reversed word: " + reversed);


// Finding the factorial of a number:
int number = 5;
int factorial = 1;
for (int i = 1; i <= number; i++)
{
    factorial *= i;
}
Console.WriteLine("Factorial of " + number + ": " + factorial);


// Sorting an array using bubble sort:

int[] arr = { 5, 1, 4, 2, 8 };
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}
Console.WriteLine("Sorted array: ");
foreach (int value in arr)
{
    Console.Write(value + " ");
}

// Converting Celsius to Fahrenheit:

double celsius = 25;
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine(celsius + " °C is equal to " + fahrenheit + " °F");


// Checking if a character is a vowel:

char ch = 'e';
bool isVowel = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
Console.WriteLine(ch + " is vowel: " + isVowel);


// Finding the maximum element in an array:

int[] numbers = { 10, 20, 5, 35 };
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine("Maximum element: " + max);


// Calculating the area of a circle:

double radius = 7;
double area = Math.PI * radius * radius;
Console.WriteLine("Area of circle: " + area);


