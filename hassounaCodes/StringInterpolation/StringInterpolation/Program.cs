// // Interpolate variables into a string
// var firstName = "John";
// var lastName = "Doe";
// var fullName = $"{firstName} {lastName}";
// Console.WriteLine(fullName);


// // Format numbers with leading zeros
// var number = 123;
// var paddedNumber = $"{number:D5}"
// Console.WriteLine(paddedNumber);

// // Display currency symbols and formats
// var price = 123.45M;
// var formattedPrice = $"{price:C}"
// Console.WriteLine(formattedPrice);

// // Use expressions inside curly braces
// var width = 10;
// var height = 20;
// var area = width * height;
// var message = $"Area is {area} sq ft."
// Console.WriteLine(message);

// // Escape curly braces for literal interpretation
// var sentence = $@"\{curly brace\}";
// Console.WriteLine(sentence);

// // Combine multiple lines with verbatim strings
// var address = $@"Street Address Line 1
//                  Street Address Line 2";
// Console.WriteLine(address);

// // Insert newline character (\n)
// var greeting = $"Hi!\nHowdy partner!"
// Console.WriteLine(greeting);

// // Concatenation with + operator
// var concatenatedGreeting = "Good morning, " + "Mr. President.";
// Console.WriteLine(concatenatedGreeting);

// // String interpolation with alignment specifier
// var centeredText = $"{centeredText,10}"
// Console.WriteLine(centeredText);

// // String interpolation with precision specifier
// var precisePi = $"{pi:0.####}"
// Console.WriteLine(precisePi);