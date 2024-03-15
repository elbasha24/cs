using System;

public classDataTypesExample
{
  public static void Main(string[] args)
  {
    // Numeric data types
    int age = 30;
    double pi = 3.14159;

    // String data type
    string name = "Alice";

    // Boolean data type
    bool isValid = true;

    // Character data type
    char initial = 'A';

    // Printing the values
    Console.WriteLine("Age: {0}", age);
    Console.WriteLine("Pi value: {0:F4}", pi);  // Format output to 4 decimal places
    Console.WriteLine("Name: {0}", name);
    Console.WriteLine("Valid: {0}", isValid);
    Console.WriteLine("Initial: {0}", initial);

    System.Console.WriteLine(33);
    System.Console.WriteLine(77.99f);
    System.Console.WriteLine(true);
    System.Console.WriteLine(false);
    System.Console.WriteLine("Hello");
    System.Console.WriteLine('H');
    System.Console.WriteLine("Hello 'Amr'");
    System.Console.WriteLine("Hello \"Amr\"");

  }
}
