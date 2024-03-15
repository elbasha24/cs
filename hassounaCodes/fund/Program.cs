System.Console.WriteLine(33);
System.Console.WriteLine(77.99f);
System.Console.WriteLine(true);
System.Console.WriteLine(false);
System.Console.WriteLine("Hello");
System.Console.WriteLine('H');
System.Console.WriteLine("Hello 'Amr'");
System.Console.WriteLine("Hello \"Amr\"");

System.Console.WriteLine("Today is: " + DateTime.Now);

System.Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
System.Console.WriteLine("Hello, " + name + "!");

int num1 = 10;
int num2 = 20;
System.Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + (num1 + num2));

double price = 19.99;
double quantity = 2;
System.Console.WriteLine("The total cost is: " + (price * quantity));
// time
// Print a specific date and time
// System.Console.WriteLine(new DateTime(2024, 3, 16));

// // Prompt the user for input and print it back
// System.Console.WriteLine("Enter your name: ");
// string name = Console.ReadLine();
// System.Console.WriteLine("Hello, " + name + "!");

// // Perform calculations and print the result
// int num1 = 10;
// int num2 = 20;
// System.Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + (num1 + num2));

// currency
double usdAmount = 99.99;

System.Console.WriteLine("Amount in Euros: {0:C2}", usdAmount * 0.92); // Assuming 1 USD = 0.92 Euros
System.Console.WriteLine("Amount in Japanese Yen: {0:C0}", usdAmount * 115.00); // Assuming 1 USD = 115 Yen

// Get user input for the amount
System.Console.WriteLine("Enter an amount: ");
string userInput = Console.ReadLine();
double amount = Convert.ToDouble(userInput);

System.Console.WriteLine("You entered: {0:C}", amount); 
/*

    System.Console.WriteLine("Ammount is: (0:C1)", 99.99f); This line prints the string "Ammount is: $99.99" to the console.
        The (0:C1) format specifier formats the value 99.99f as currency with one decimal place.
        The f suffix at the end of the number specifies that it's a single-precision floating-point number.
    System.Console.WriteLine("Ammount is: {0:c3}", 99.99f); This line prints the string "Ammount is: $9,999.90" to the console.
        The {0:c3} format specifier formats the value 99.99f as currency with three decimal places.
    System.Console.WriteLine("Ammount is: {0:C5}", 99.99f); This line prints the string "Ammount is: $99,999.90000" to the console.
        The {0:c5} format specifier formats the value 99.99f as currency with five decimal places.

*/ 

System.Console.WriteLine("Today is: {0:dddd, MMMM d, yyyy}", System.DateTime.Now); // Print date in a more descriptive format
System.Console.WriteLine("Time is: {0:h:mm:ss tt}", System.DateTime.Now); // Print time with hours, minutes, seconds and AM/PM

// Print the date and time in a custom format
System.Console.WriteLine("Date and Time: {0:yyyy'-'MM'-'dd HH:mm:ss}", System.DateTime.Now); 
/*


    System.Console.WriteLine("{0:d)", System.DateTime.Now);
        This line prints the current date in a short date format (e.g., "2024-03-16") to the console.
        The {0} placeholder represents the value to be formatted.
        The :d format specifier formats the current date obtained from System.DateTime.Now according to the short date format.

    System.Console.WriteLine("{0:t)", System.DateTime.Now );
        This line prints the current time in a short time format (e.g., "08:45 AM") to the console.
        The format specifier is similar to the previous line, but uses the :t specifier for short time formatting.

*/

System.Console.WriteLine("{0:dd}", System.DateTime.Now);
System.Console.WriteLine("{0:MM}", System.DateTime.Now);
System.Console.WriteLine("{0:yyyy}", System.DateTime.Now);
// Commented out line (assuming it's for two-digit year and twelve-hour hour)
// System.Console.WriteLine("{0:yy}", System.DateTime.Now);  
// System.Console.WriteLine("{0:hh}", System.DateTime.Now);
System.Console.WriteLine("{0:mm}", System.DateTime.Now);
System.Console.WriteLine("{0:ss}", System.DateTime.Now);
System.Console.WriteLine("{0:tt}", System.DateTime.Now);
/*
    :dd - Two-digit day
    :MM - Two-digit month
    :yyyy - Four-digit year
    // Commented out: :yy - Two-digit year (commented out)
    // Commented out: :hh - Twelve-hour hour (commented out)
    :mm - Two-digit minute
    :ss - Two-digit second
    :tt - Two-character AM/PM indicator

*/

System.Console.WriteLine("{0:dd}", System.DateTime.Now); // Print the day in two-digit format
System.Console.WriteLine("{0:MM}", System.DateTime.Now); // Print the month in two-digit format
System.Console.WriteLine("{0:yyyy}", System.DateTime.Now); // Print the year in four-digit format
System.Console.WriteLine("{0:yy}", System.DateTime.Now);    // Print the year in two-digit format (commented out)
System.Console.WriteLine("{0:hh}", System.DateTime.Now);   // Print the hour in twelve-hour format (commented out)
System.Console.WriteLine("{0:mm}", System.DateTime.Now); // Print the minutes in two-digit format
System.Console.WriteLine("{0:ss}", System.DateTime.Now); // Print the seconds in two-digit format
System.Console.WriteLine("{0:tt}", System.DateTime.Now); // Print AM or PM indicator

// Block 1 (Extracted code)
System.Console.WriteLine("{0:dd}", DateTime.Now); // Print two-digit day
System.Console.WriteLine("{0:MM}", DateTime.Now); // Print two-digit month
System.Console.WriteLine("{0:yyyy}", DateTime.Now); // Print four-digit year
System.Console.WriteLine("{0:mm}", DateTime.Now); // Print two-digit minute
System.Console.WriteLine("{0:ss}", DateTime.Now); // Print two-digit second
System.Console.WriteLine("{0:tt}", DateTime.Now); // Print two-character AM/PM format

// // Block 2 - Date in long format
// System.Console.WriteLine("{0:dddd, MMMM d, yyyy}", DateTime.Now); // Print date in long format (e.g., Friday, March 15, 2024)

// // Block 3 - Time with hours, minutes, seconds
// System.Console.WriteLine("{0:h:mm:ss tt}", DateTime.Now); // Print time with hours, minutes, seconds, and AM/PM

// // Block 4 - Currency with one decimal place
// System.Console.WriteLine("Ammount is: ${0:C1}", 99.99f); // Print currency with one decimal place

// // Block 5 - Currency with three decimal places
// System.Console.WriteLine("Ammount is: ${0:C3}", 99.99f); // Print currency with three decimal places

// // Block 6 - Currency with five decimal places
// System.Console.WriteLine("Ammount is: ${0:C5}", 99.99f); // Print currency with five decimal places

// // Block 7 - Get user input for age and print it
// System.Console.WriteLine("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Your age is: {0}", age);

// // Block 8 - Get user input for name and print it with a greeting
// System.Console.WriteLine("Enter your name: ");
// string name = Console.ReadLine();
// System.Console.WriteLine("Hello, {0}!", name);

// // Block 9 - Calculate area of a rectangle and print it
// System.Console.WriteLine("Enter width of rectangle: ");
// double width = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter height of rectangle: ");
// double height = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Area of rectangle: {0:F2}", width * height); // Print area with two decimal places

// // Block 10 - Generate a random number between 1 and 100 and print it
// Random random = new Random();
// int randomNumber = random.Next(1, 101);
// System.Console.WriteLine("Random number: {0}", randomNumber);

/*

    Printing dates in long format
    Printing time with hours, minutes, and seconds
    Formatting currency with different decimal places
    Getting user input and printing it back
    Performing calculations and formatting the output
    Generating random numbers

*/

