// dataSize

// Console.WriteLine("Size of char:\t\t{0} bytes", sizeof(char));
// Console.WriteLine("Size of sbyte:\t\t{0} bytes", sizeof(sbyte));
// Console.WriteLine("Size of short:\t\t{0} bytes", sizeof(short));
// Console.WriteLine("Size of ushort:\t{0} bytes", sizeof(ushort));
// Console.WriteLine("Size of int:\t\t{0} bytes", sizeof(int));
// Console.WriteLine("Size of uint:\t\t{0} bytes", sizeof(uint));
// Console.WriteLine("Size of long:\t\t{0} bytes", sizeof(long));
// Console.WriteLine("Size of ulong:\t{0} bytes", sizeof(ulong));
// Console.WriteLine("Size of float:\t\t{0} bytes", sizeof(float));
// Console.WriteLine("Size of double:\t{0} bytes", sizeof(double));
// Console.WriteLine("Size of decimal:\t{0} bytes", sizeof(decimal));
// Console.WriteLine("Size of IntPtr:\t{0} bytes", sizeof(IntPtr));
// Console.WriteLine("Size of UIntPtr:\t{0} bytes", sizeof(UIntPtr));
// Console.WriteLine("Size of pointer:\t{0} bytes", sizeof(pointer));
// Console.WriteLine("Size of boolean:\t{0} bytes", sizeof(boolean));
// Console.WriteLine("Size of Boolean:\t{0} bytes", sizeof(Boolean));
// Console.WriteLine("Size of Byte:\t{0} bytes", sizeof(byte));
// Console.WriteLine("Size of SByte:\t{0} bytes", sizeof(byte));
// Console.WriteLine("Size of Char:\t{0} bytes", sizeof(Char));

System.Console.WriteLine("{0:dd}", System.DateTime.Now); // Print two-digit day
System.Console.WriteLine("{0:MM}", System.DateTime.Now); // Print two-digit month
System.Console.WriteLine("{0:yyyy}", System.DateTime.Now); // Print four-digit year
// Commented out: Print two-digit year and twelve-hour hour in separate lines
// System.Console.WriteLine("{0:yy}", System.DateTime.Now);  
// System.Console.WriteLine("{0:hh}", System.DateTime.Now);
System.Console.WriteLine("{0:mm}", System.DateTime.Now); // Print two-digit minute
System.Console.WriteLine("{0:ss}", System.DateTime.Now); // Print two-digit second
System.Console.WriteLine("{0:tt}", System.DateTime.Now); // Print two-character AM/PM format

System.Console.WriteLine(47); // Output the number 47
System.Console.WriteLine(7 - 3); // Subtract 3 from 7 and output the result (4)
System.Console.WriteLine(7 * 3); // Multiply 7 by 3 and output the result (21)
System.Console.WriteLine(7 / 3f); // Divide 7 by 3 as floating-point numbers and output the result (2.3333333)
// System.Console.WriteLin47%* is removed as it's incomplete and unclear what it intended to do
int num = 9;
int num2=12;
string name = "Amr";
double salary = 199f; // Can also be written as 199.0
bool isActive = true; // Assuming IsActive should be true or false
char charValue = '@'; // Consistent naming convention

System.Console.WriteLine("{0} {1}", num, name);
System.Console.WriteLine(salary);
System.Console.WriteLine(isActive);
System.Console.WriteLine(charValue);
System.Console.WriteLine(num2); // No changes needed for ushort

//increment and decrement
int x = 0;

System.Console.WriteLine(x); // Print initial value (0)

x++; // Post-increment (print 0, then increment to 1)
System.Console.WriteLine(x); // Print incremented value (1)

++x; // Pre-increment (increment to 2, then print 2)
System.Console.WriteLine(x); // Print incremented value (2)

x--; // Post-decrement (print 2, then decrement to 1)
System.Console.WriteLine(x); // Print decremented value (1)

--x; // Pre-decrement (decrement to 0, then print 0)
System.Console.WriteLine(x); // Print decremented value (0)

// // US/UK numbering system (commas every three digits, period as decimal separator):
// long usNumber = 123456789012345678;
// System.Console.WriteLine(usNumber.ToString("N"));
// // Output: 12,345,678,901,234,567,800

// // European numbering system (periods every three digits, comma as decimal separator):
// long europeanNumber = 123456789012345678;
// System.Console.WriteLine(europeanNumber.ToString("F", CultureInfo.GetCultureInfo("fr-FR")));
// // Output: 12.345.678.901.234.567.800

// // Custom precision for scientific notation:
// long largeNumber = 1234567890000000000;
// System.Console.WriteLine(largeNumber.ToString("E2"));
// // Output: 1.23E+17

long big_number = 777_000_000_999_333;
// Correct format specifier for Indian numbering system:
System.Console.WriteLine(big_number.ToString("#,##,##,##,##,##,##0"));

//string format

// string name = "Charlie";
// int age = 25;
// double price = 1234.5678;

// // String Interpolation Examples:
// string greeting = $"Hello, {name}! You are {age} years old.";
// System.Console.WriteLine(greeting); // Output: Hello, Charlie! You are 25 years old.

// string formattedPrice = $"The price is ${price:F2}"; // Two decimal places for currency
// System.Console.WriteLine(formattedPrice); // Output: The price is $1234.57

// // String.Format Examples:
// string message = String.Format("Hi, {0}! Today's date is {1:yyyy-MM-dd}", name, DateTime.Now);
// System.Console.WriteLine(message); // Output: Hi, Charlie! Today's date is 2024-03-16 (assuming today's date)

// string hexValue = String.Format("The hex value is 0x{0:X4}", 255); // Uppercase hexadecimal with four digits
// System.Console.WriteLine(hexValue); // Output: The hex value is 0xFF

// // String Interpolation with calculations:
// int discount = 10;
// double discountedPrice = price * (1 - discount / 100.0);
// string discountMessage = $"The discounted price for {name} is ${discountedPrice:F2}";
// System.Console.WriteLine(discountMessage);  // Output (assuming Charlie): The discounted price for Charlie is $1111.11

