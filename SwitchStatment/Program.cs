Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter operator (+, -, *, /): ");
char op = Convert.ToChar(Console.ReadLine());
Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double result = 0;

switch (op)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero");
        }
        else
        {
            result = num1 / num2;
        }
        break;
    default:
}

