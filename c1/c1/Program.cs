internal class Program
{
    private static void Main(string[] args)
    {
        int a = 12;
        Console.WriteLine(a);
        if (a == 12)
        {
            Console.WriteLine($"the number  is {a}");
        }
        else
        {
            Console.WriteLine($"the number  is not 12 it's {a}");
        }
        //datatypes in C#
        int x = 5; //integer
        double d = 12.5d;
        float f = 12.5f;
        System.Console.WriteLine(d);
        System.Console.WriteLine(f);

        string s = "Nasr";
        System.Console.WriteLine(s.Replace('N', 'A')); // replace N with A
        System.Console.WriteLine(s.CompareTo("NASR")); // compare s with "NASR"
        System.Console.WriteLine(s.Length); // get the length of s
        System.Console.WriteLine(s.ToLower()); // convert s to lowercase
        System.Console.WriteLine(s.ToUpper()); // convert s to uppercase
        System.Console.WriteLine(s.Normalize()); // normalize the string s
        System.Console.WriteLine(s.Substring(1)); // get a substring starting from index 1
        System.Console.WriteLine(s.Contains("as")); // check if s contains the substring "as"
        System.Console.WriteLine(s.IndexOf("s")); // get the index of the first occurrence of "s" in s
        System.Console.WriteLine(s.LastIndexOf("s")); // get the index of the last occurrence of "s" in s
        System.Console.WriteLine(s.StartsWith("N")); // check if s starts with "N"
        System.Console.WriteLine(s.EndsWith("r")); // check if s ends with "r"
        System.Console.WriteLine(s.Trim()); // remove leading and trailing whitespace from s

        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName); // Output: John Doe

        string city = "New York City";
        string subString = city.Substring(5); // Extracts "York City"
        Console.WriteLine(subString);

        string greeting = "Hello, world!";
        int length = greeting.Length;
        Console.WriteLine(length); // Output: 14

        string sentence = "The quick brown fox jumps over the lazy dog.";
        int index = sentence.IndexOf("fox"); // Finds the index of "fox" (16)
        Console.WriteLine(index);

        string email = "user@example.com";
        bool hasCom = email.Contains(".com"); // Checks if ".com" is present
        Console.WriteLine(hasCom); // Output: True

        string website = "www.microsoft.com";
        bool startsWithWww = website.StartsWith("www"); // Checks if it starts with "www"
        bool endsWithCom = website.EndsWith(".com"); // Checks if it ends with ".com"
        Console.WriteLine(startsWithWww); // Output: True
        Console.WriteLine(endsWithCom); // Output: True

        string title = "This is a Title";
        string lowercaseTitle = title.ToLower(); // Converts to lowercase
        string uppercaseTitle = title.ToUpper(); // Converts to uppercase
        Console.WriteLine(lowercaseTitle); // Output: this is a title
        Console.WriteLine(uppercaseTitle); // Output: THIS IS A TITLE

        string message = "   Hello, how are you?   ";
        string trimmedMessage = message.Trim(); // Removes leading/trailing whitespace
        Console.WriteLine(trimmedMessage); // Output: Hello, how are you?

        string names = "John, Jane, Alice";
        string[] nameArray = names.Split(','); // Splits into an array
        foreach (string name3 in nameArray)
        {
            Console.WriteLine(name3);
        }
        // Output:
        // John
        // Jane
        // Alice

        // string format
        string path = "C:\\temp\\myFile.txt";
        string newPath = path.Replace("\\", "/"); // Replaces "\

        string name = "Alice";
        int age = 30;
        string message2 = string.Format("Hello, my name is {0} and I am {1} years old.", name, age);
        Console.WriteLine(message2); // Output: Hello, my name is Alice and I am 30 years old.

        string product = "T-shirt";
        double price = 19.99;
        string ad = $"Buy our amazing {product} for only ${price:.2f}!";
        Console.WriteLine(ad); // Output: Buy our amazing T-shirt for only $19.99!

        // String interpolation:

        string city2 = "New York";
        string state = "NY";
        string location = $"{city2}, {state}";
        Console.WriteLine(location); // Output: New York, NY

    }
}