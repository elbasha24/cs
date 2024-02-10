Random random = new Random();
int randomNumber = random.Next(1, 11); // Generates a number between 1 and 10 (inclusive)
System.Console.WriteLine(randomNumber);
// Generating a random double:
double randomDouble = random.NextDouble(); // Generates a number between 0 (inclusive) and 1 (exclusive)
System.Console.WriteLine(randomDouble);

// Shuffling an array:
string[] names = { "Alice", "Bob", "Charlie" };

for (int i = 0; i < names.Length; i++)
{
    int swapIndex = random.Next(i, names.Length);
    string temp = names[i];
    names[i] = names[swapIndex];
    names[swapIndex] = temp;
}

// Simulating a coin toss:
bool isHeads = random.NextDouble() >= 0.5; // True for heads, False for tails
System.Console.WriteLine(isHeads);

//Rolling a die:
int dieRoll = random.Next(1, 7); // Generates a number between 1 and 6 (inclusive)
System.Console.WriteLine(dieRoll);

// Choosing a random element from a list:
// Random random = new Random();
List<string> colors = new List<string>() { "red", "green", "blue" };
int randomIndex = random.Next(colors.Count);
string randomColor = colors[randomIndex];

// Generating a random password:
// Random random = new Random();
// const string passwordCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
// StringBuilder password = new StringBuilder();
// for (int i = 0; i < 12; i++)
// {
//     int randomIndex = random.Next(passwordCharacters.Length);
//     password.Append(passwordCharacters[randomIndex]);
// }
// string generatedPassword = password.ToString();

int randomNumber2 = random.Next(1, 101); // Inclusive range
Console.WriteLine(randomNumber);
System.Console.WriteLine(randomNumber2);
//Generating a random double between 0 and 1 (exclusive):

// Random random = new Random();
double randomDouble2 = random.NextDouble();
Console.WriteLine(randomDouble2);
//Generating a random string of specific length:

// Random random = new Random();
string randomString = "";
for (int i = 0; i < 10; i++) // Generate 10-character string
{
    randomString += (char)random.Next(65, 91); // Capital letters
}
Console.WriteLine(randomString);

//Generating a random element from an array:

string[] names2 = { "Alice", "Bob", "Charlie" };
// Random random = new Random();
int index = random.Next(0, names.Length);
string randomName3 = names[index];
Console.WriteLine(randomName3);

//Generating random numbers within a specific range (inclusive):

// Random random = new Random();
int min = 5;
int max = 15;
int randomNumber5 = random.Next(min, max + 1); // Inclusive max
Console.WriteLine(randomNumber5);

//Generating a random boolean value:

// Random random = new Random();
bool randomBool2 = random.Next(2) == 0; // True or False with equal probability
Console.WriteLine(randomBool2);

//Generating random numbers from a custom distribution:

// Define a custom distribution function
// double CustomDistribution(double x)
// {
//     return Math.Exp(-x); // Example: Exponential distribution
// }

// // Random random = new Random();
// double randomValue6 = random.NextDouble();
// double customValue6 = CustomDistribution(randomValue);
// Console.WriteLine(customValue6);


//Generating random dates within a specific range:

// Random random = new Random();
DateTime startDate = new DateTime(2023, 1, 1);
DateTime endDate = new DateTime(2023, 12, 31);
TimeSpan timeSpan = endDate - startDate;
int days = timeSpan.Days;
int randomDay = random.Next(days);
DateTime randomDate = startDate.AddDays(randomDay);
Console.WriteLine(randomDate);

// Generating random passwords with specific criteria:

// string GeneratePassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
// {
//     // Random random = new Random();
//     StringBuilder password = new StringBuilder();
//     const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
//     const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//     const string numberChars = "0123456789";
//     const string symbolChars = "!@#$%^&*()_+-=[]{}|;':\"\\,<.>/?";

//     string charSet = "";
//     if (includeLowercase) charSet += lowercaseChars;
//     if (includeUppercase) charSet += uppercaseChars;
//     if (includeNumbers) charSet += numberChars;
//     if (includeSymbols) charSet += symbolChars;

//     for (int i = 0; i < length; i++)
//     {
//         int index = random.Next(charSet.Length);
//         password.Append(charSet[index]);
//     }

//     return password.ToString();
// }

// Console.WriteLine(GeneratePassword(10, true, true, true, true)); // Example: 10-character password with all criteria

//Generate a random integer within a range:
// int min = 5;
// int max = 10;
// int randomInRange = random.Next(min, max + 1); // Generates a random integer between min (inclusive) and max (inclusive)


// Generate a random boolean:

bool randomBool = random.Next(2) == 0; // Generates true or false with equal probability
System.Console.WriteLine(randomBool);

//Generate a random string:
// string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
// int stringLength = 10;
// char[] randomString = new char[stringLength];
// for (int i = 0; i < stringLength; i++)
// {
//     randomString[i] = chars[random.Next(chars.Length)];
// }
// string result = new string(randomString);



