// Here's how to create classes in , along with 10 examples covering various concepts:

// 1. Basic Class Structure:


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}



// 2. Constructor:


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}



// 3. Access Modifiers (public, private, protected):


class Person
{
    private string name; // Private field
    public int Age { get; set; } // Public property

    public Person(string name, int age)
    {
        this.name = name;
        Age = age;
    }

    public string GetName()
    {
        return name;
    }
}



// 4. Static Members:


class Person
{
    public static int Count = 0;

    public Person()
    {
        Count++;
    }
}

// 5. Inheritance:


class Employee : Person
{
    public string JobTitle { get; set; }
}



// 6. Abstract Classes:


abstract class Shape
{
    public abstract double CalculateArea();
}



// 7. Interfaces:


interface IPrintable
{
    void Print();
}

class Book : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing the book...");
    }
}



// 8. Generic Classes:


class Box<T>
{
    public T Value { get; set; }
}



// 9. Nested Classes:


class Car
{
    public class Engine
    {
        public int Horsepower { get; set; }
    }
}



// 10. Partial Classes:


// Part 1:
partial class Person
{
    public string Name { get; set; }
}

// Part 2 (in a different file):
partial class Person
{
    public int Age { get; set; }
}



// Remember:

//     Use class keyword followed by class name.
//     Enclose class body in curly braces.
//     Define properties and methods within the class.
//     Instantiate objects using new keyword.

