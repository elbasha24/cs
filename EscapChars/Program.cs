// Here are 10 C# code examples demonstrating the use of escape characters:




internal class Program
{
    private static global::System.Int32 Main(string[] args)
    {
        // 1. Newline (\n): This represents a new line in text files or console output.
        Console.WriteLine("Hello" + "\n" + "World");
        Console.WriteLine("This is the\nfirst line.");
        Console.WriteLine("This is the second line.");

        // 2. Tab (\t):
        Console.WriteLine("Name:\tAlice");
        Console.WriteLine("Age:\t30");

        // 3. Double quote ("):
        string quote = "He said, \"Hello, world!\"";
        Console.WriteLine(quote);

        // 4. Backslash ():

        // string filePath = @"C:\Users\John\Documents";
        // Console.WriteLine(filePath);

        // 5.Single quote('):

        string message = 'You can\'t use double quotes here.';
        Console.WriteLine(message);
        // 6.Bell(\a):
        Console.WriteLine("This is an alert!\a");
        // 7.Carriage return (\r):

        string text = "Line 1\rLine 2";
        Console.WriteLine(text); // Only shows "Line 1" in most consoles

        // 8.Vertical tab(\v):

        string multiline = "Line 1\vLine 2\vLine 3";
        Console.WriteLine(multiline); // Lines appear stacked in some consoles

        // 9.Null(\0):
        char nullChar = '\0'; // Unprintable null character
        string name = "John" + nullChar + "Doe"; // Adds an invisible character
        Console.WriteLine(name.Length); // Length includes null character

        // 10.Unicode escape sequences:

        string greekLetter = "\u0391"; // Unicode escape for alpha
        string chineseCharacter = "\u4e2d"; // Unicode escape for "middle"
        Console.WriteLine(greekLetter + " " + chineseCharacter);
    }
}



// Remember that escape characters are used to represent special characters or control formatting within strings.
//  Choose the appropriate escapes based on your desired output and potential compatibility issues.