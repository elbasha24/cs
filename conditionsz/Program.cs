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

        int number = 7;
        if (number % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }

        // long (Long integer):

        long population = 8000000000;
        if (population > 1000000000)
        {
            Console.WriteLine("Large population");
        }
        else
        {
            Console.WriteLine("Smaller population");
        }

        // double (Double-precision floating-point):

        double temperature = 23.5;
        if (temperature > 30)
        {
            Console.WriteLine("Hot day");
        }
        else if (temperature > 20)
        {
            Console.WriteLine("Pleasant day");
        }
        else
        {
            Console.WriteLine("Cold day");
        }

        // bool (Boolean):

        bool isLoggedIn = true;
        if (isLoggedIn)
        {
            Console.WriteLine("Welcome back!");
        }
        else
        {
            Console.WriteLine("Please log in");
        }

        // string (String):

        string name = "John";
        if (name == "Alice")
        {
            Console.WriteLine("Hello, Alice!");
        }
        else
        {
            Console.WriteLine("Hello, " + name);
        }


        // char (Character):

        char vowel = 'e';
        if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
        {
            Console.WriteLine("Vowel");
        }
        else
        {
            Console.WriteLine("Consonant");
        }


        // array (Array of integers):

        int[] numbers = { 1, 3, 5, 7 };
        if (Array.IndexOf(numbers, 2) >= 0)
        {
            Console.WriteLine("2 is present in the array");
        }
        else
        {
            Console.WriteLine("2 is not present");
        }

        Person person = new Person { Name = "Jane", Age = 25 };
        if (person.Age >= 18)
        {
            Console.WriteLine(person.Name + " is an adult");
        }
        else
        {
            Console.WriteLine(person.Name + " is not an adult");
        }
        Color favoriteColor = Color.Blue;
        if (favoriteColor == Color.Green)
        {
            Console.WriteLine("Your favorite color is green");
        }
        else
        {
            Console.WriteLine("Your favorite color is not green");
        }


        // Tuple

        (string firstName, int age) userInfo = ("Alice", 30);
        if (userInfo.age > 25)
        {
            Console.WriteLine(userInfo.firstName + " is older than 25");
        }
        else
        {
            Console.WriteLine(userInfo.firstName + " is not older than 25");
        }
    }
}


// class (Custom class):

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// enum (Enumeration):

enum Color { Red, Green, Blue };
