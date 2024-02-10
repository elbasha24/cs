// Here are 10 examples of the String.Format method for custom formatting in C#:

// 1. Currency:


internal class Program
{
    private static void Main(string[] args)
    {
        decimal price = 1234.56m;
        string formattedPrice = String.Format("Price: {0:C}", price); // Output: Price: $1,234.56

        // Different currencies:
        string euroPrice = String.Format("Price: {0:€}", price); // Output: Price: €1.234,56
        string yenPrice = String.Format("Price: {0:¥}", price); // Output: Price: ¥1,234.56



        // 2. Dates:


        DateTime today = DateTime.Today;
        string shortDate = String.Format("Date: {0:d}", today); // Output: Date: 2024-02-10
        string longDate = String.Format("Date: {0:D}", today); // Output: Date: Saturday, February 10, 2024
        string time = String.Format("Time: {0:t}", today); // Output: Time: 01:46:00 AM



        // 3. Digits and padding:


        int number = 123;
        string paddedNumber = String.Format("Number: {0:D5}", number); // Output: Number: 00123
        double pi = 3.14159;
        string roundedPi = String.Format("PI (2 decimals): {0:0.00}", pi); // Output: PI (2 decimals): 3.14



        // 4. Percentages:


        decimal discount = 0.25m;
        string formattedDiscount = String.Format("Discount: {0:P2}", discount); // Output: Discount: 25.00%



        // 5. Custom format strings:


        int days = 365;
        string yearInfo = String.Format("Days in a year (including leap years): {0:#,0}", days); // Output: Days in a year (including leap years): 365,25



        // 6. Combining formats:


        Person person = new Person { Name = "John", Age = 30 };
        string personInfo = String.Format("Name: {0}, Age: {1:D2}", person.Name, person.Age); // Output: Name: John, Age: 30



        // 7. Using placeholders:


        string template = "Product {0}: Price: {1:C}, Stock: {2}";
        object[] productData = new object[] { "A123", 19.99m, 25 };
        string formattedProduct = String.Format(template, productData); // Output: Product A123: Price: $19.99, Stock: 25



        // 8. Formatting numbers based on culture:


        CultureInfo frenchCulture = CultureInfo.GetCultureInfo("fr-FR");
        string frenchPrice = String.Format(frenchCulture, "Prix: {0:C}", price); // Output: Prix: 1.234,56 €

        double distance = 10.5;
        UnitFormatter formatter = new UnitFormatter();
        string formattedDistance = String.Format(formatter, "{0:U}", distance); // Output: 10.50 units



        10.Formatting large datasets:


StringBuilder sb = new StringBuilder();
        foreach (Product product in products)
        {
            sb.AppendFormat("Product Name: {0}, Price: {1:C}\n", product.Name, product.Price);
        }
        string formattedProducts = sb.ToString();
    }
}



// 9. Custom formatting with IFormatProvider:


class UnitFormatter : IFormatProvider, ICustomFormatter
{
    public object GetFormat(Type formatType)
    {
        if (formatType == typeof(ICustomFormatter))
        {
            return this;
        }
        return null;
    }

    public string Format(string format, object arg, IFormatProvider formatProvider)
    {
        if (arg is double)
        {
            double value = (double)arg;
            return $"{value.ToString("0.00")} units";
        }
        return null;
    }
}