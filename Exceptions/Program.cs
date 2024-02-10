// 1- Basic try-catch for division by zero:

// int num1 = 10;
// int num2 = 0;

// try
// {
//     int result = num1 / num2;
//     Console.WriteLine(result);
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Error: Division by zero!");
// }

// 2-Catching specific exceptions based on type:

// string userInput = Console.ReadLine();

// try
// {
//     int number = int.Parse(userInput);
//     Console.WriteLine("You entered: " + number);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Invalid input. Please enter a number.");
// }
// catch (OverflowException)
// {
//     Console.WriteLine("The number is too large or too small.");
// }


// 3- Using the 'finally' block:

// StreamReader reader = new StreamReader("data.txt");

// try
// {
//     string line;
//     while ((line = reader.ReadLine()) != null)
//     {
//         Console.WriteLine(line);
//     }
// }
// catch (FileNotFoundException)
// {
//     Console.WriteLine("File not found!");
// }
// finally
// {
//     if (reader != null)
//     {
//         reader.Close(); // Ensure file is closed even if exceptions occur
//     }
// }


// 4-. Throwing custom exceptions:

// public class AgeException : Exception
// {
//     public AgeException(string message) : base(message) { }
// }

// void ValidateAge(int age)
// {
//     if (age < 18)
//     {
//         throw new AgeException("You must be at least 18 years old.");
//     }
// }

// try
// {
//     ValidateAge(15);
// }
// catch (AgeException ex)
// {
//     Console.WriteLine(ex.Message);
// }


// 5. Using nested try-catch blocks:

// try
// {
//     try
//     {
//         int num = int.Parse(Console.ReadLine());
//         Console.WriteLine("You entered: " + num);
//     }
//     catch (FormatException ex)
//     {
//         Console.WriteLine("Invalid input format: " + ex.Message);
//     }
// }
// catch (Exception ex) // Outer catch handles any unexpected exceptions
// {
//     Console.WriteLine("An error occurred: " + ex.Message);
// }


// 6. Rethrowing exceptions:

// void ReadFile(string filename)
// {
//     try
//     {
//         StreamReader reader = new StreamReader(filename);
//         // ...
//     }
//     catch (FileNotFoundException)
//     {
//         throw; // Rethrow the exception to the caller
//     }
// }

// try
// {
//     ReadFile("nonexistent.txt");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("File not found: " + ex.Message);
// }


// 7. Using exception filters:

// try
// {
//     int result = 10 / 0; // This will cause a DivideByZeroException
// }
// catch (DivideByZeroException ex) when (ex.Message.Contains("10")) // Filter based on exception message
// {
//     Console.WriteLine("You tried to divide 10 by zero.");
// }


// 8. Logging exceptions:

// try
// {
//     // Code that might throw an exception
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error: " + ex.Message);
//     // Log the exception details to a file or database
// }


// 9. Handling aggregate exceptions:

// List<Task> tasks = new List<Task>();
// // Create and start multiple tasks

// try
// {
//     Task.WaitAll(tasks.ToArray()); // Wait for all tasks to finish
// }
// catch (AggregateException ex)
// {
//     foreach (Exception innerEx in ex.InnerExceptions)
//     {
//         Console.WriteLine("Inner exception: " + innerEx.Message);
//     }
// }


// 10. Using the 'using' statement for automatic resource management:
// using (StreamReader reader = new StreamReader("data.txt"))
// {
//     string line;
//     while ((line = reader.ReadLine()) != null)
//     {
//         Console.WriteLine(line);
//     }
// } // Reader is automatically closed when the block ends

// Catching multiple exceptions:

// try
// {
//     // Code that might throw different exceptions
//     string text = Console.ReadLine();
//     int num = int.Parse(text);
// }
// catch (FormatException ex)
// {
//     Console.WriteLine("Error: Invalid input format.");
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Error: Number too large or too small.");
// }


// Using finally block:

// try
// {
//     // Code that might throw an exception
//     StreamReader reader = new StreamReader("data.txt");
//     // ...
// }
// finally
// {
//     // Ensure resources are released even if an exception occurs
//     if (reader != null)
//     {
//         reader.Close();
//     }
// }

// Using checked and unchecked keywords:

// checked
// {
//     int num = int.MaxValue + 1; // Throws OverflowException
// }

// unchecked
// {
//     int num = int.MaxValue + 1; // Wraps around without exception
// }


//  Using IDisposable interface for custom cleanup:

// class MyResource : IDisposable
// {
//     public void Dispose()
//     {
//         // Clean up resources
//     }
// }

// using (MyResource resource = new MyResource())
// {
//     // Use the resource here
// } // Resource is automatically disposed
