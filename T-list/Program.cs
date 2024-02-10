internal class Program
{
    private static void Main(string[] args)
    {
        // Here are examples of codes using < T > lists.
        // List<int> intList = new List<int>():
        // 1. Creating and using a generic list:

        List<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 2. Accessing elements:
        // Get the first element
        string firstName = names[0];
        // Check for an element's existence
        bool hasBob = names.Contains("Bob");
        // 3. Adding and removing elements:
        names.Add("David"); // Add to the end
        names.Insert(1, "Emily"); // Insert at a specific index
        names.Remove("Bob"); // Remove by value
        names.RemoveAt(2); // Remove by index
        // 4. Searching and sorting:
        int indexOfCharlie = names.IndexOf("Charlie"); // Get the index of an element
        names.Sort(); // Sort alphabetically
        // 5. Iterating over the list:
        foreach (string name in names)
        {
            // Process each name
        }

        for (int i = 0; i < names.Count; i++)
        {
            // Access elements by index
        }

        // 6. Using other methods and properties:
        int count = names.Count; // Get the number of elements
        names.Clear(); // Remove all elements
        bool isEmpty = names.Count == 0; // Check if the list is empty
        // 7. Generic methods with lists:
       

        void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        PrintList(names);
        // 8. Nested lists:
        List<List<int>> numbers = new List<List<int>>();
        numbers.Add(new List<int>() { 1, 2, 3 });
        numbers.Add(new List<int>() { 4, 5, 6 });
        // 9. List as a parameter or return type:
    
        List<string> GetFilteredNames(List<string> names, string filter)
        {
            // Filter names based on some criteria
            return filteredNames;
        }

        // 10. Converting a list to an array:
        string[] nameArray = names.ToArray();
    }
}