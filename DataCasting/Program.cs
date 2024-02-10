// 1 Explicit casting:

// Widening cast: Converting from a smaller data type to a larger one.

int age = 25;
long population = (long)age; // Explicitly cast int to long
Console.WriteLine(population); // Output: 25


// Narrowing cast: Converting from a larger data type to a smaller one (potential data loss).

double PI = 3.14159;
int roundedPI = (int)PI; // Explicitly cast double to int, loses decimal precision
Console.WriteLine(roundedPI); // Output: 3


// 2. Implicit casting: The compiler automatically performs this conversion for you if there is an implicit operator defined in the class or struct
// Automatic conversion when assigning compatible values between different data types.

double price = 19.99;
int priceInt = (int)price; // Implicit conversion from double to int
Console.WriteLine(priceInt); // Output: 19 (truncates decimal part)


// 3 Casting reference types:

// Using as operator to check type compatibility before casting.

object data = "hello";
string message = data as string; // Cast to string if possible
if (message != null)
{
    Console.WriteLine(message); // Output: hello
}

// 4 Casting with boxing and unboxing:

// Primitive values are boxed to reference types and unboxed back for operations.

int number = 10;
object boxedNumber = number; // Boxing - primitive to reference
int unboxedNumber = (int)boxedNumber; // Unboxing - reference to primitive
Console.WriteLine(unboxedNumber); // Output: 10


// 5. Using Convert class:

// Provides static methods for various conversions, including string parsing.

string ageString = "30";
int ageInt = Convert.ToInt32(ageString); // Parse string to int
Console.WriteLine(ageInt); // Output: 30


// 6. Generic methods with constraints:
// Methods can specify type constraints for casting within the method logic.

T Add<T>(T value1, T value2) where T : struct // Constrain to value types
{
    return value1 + value2;
}

int sum = Add(5, 2); // Adding integers
Console.WriteLine(sum); // Output: 7


// 7. Casting between custom types:
// User-defined classes can implement implicit or explicit casting operators.

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static implicit operator string(Point point)
    {
        return "(" + point.X + ", " + point.Y + ")";
    }
}

Point p = new Point { X = 3, Y = 4 };
string pointString = (string)p; // Implicitly cast to string
Console.WriteLine(pointString); // Output: (3, 4)


// 8. Casting pointers (unsafe context):

// Advanced operation for converting memory addresses between types (use with caution).
unsafe
{
    int number = 10;
    int* ptr = &number;
    long* longPtr = (long*)ptr; // Cast integer pointer to long pointer
    Console.WriteLine(*longPtr); // Prints the value at the memory address
}


// Avoiding unnecessary casting:

//     Avoid casting unless clearly needed to prevent potential data loss and type safety issues.

// 10. Using appropriate data types:

//     Choose the correct data types for your variables to minimize casting and maintain code clarity.

// Remember, casting should be used judiciously when necessary for data manipulation, type compatibility,
// or interfacing with different APIs. Always consider the potential risks and choose the most appropriate casting options for your specific needs.
