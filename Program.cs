////// first number 
////int firstNumber = 5;
////// second number
////int secondNumber = 10;

////int result = firstNumber + secondNumber;
////Console.WriteLine("The addition of both numbers is {0}", result);
////Console.ReadKey();

//// now we get input from the user
////Console.WriteLine("Enter the first number: ");
////int firstNumber = Convert.ToInt32(Console.ReadLine());

////Console.WriteLine("Enter the second number: ");
////int secondNumber = Convert.ToInt32(Console.ReadLine());

////int result = firstNumber + secondNumber;

////Console.WriteLine("The addition of both numbers is {0}", result);

//CalculatorApp();
//void CalculatorApp()
//{
//    int firstNumber = 0;
//    int secondNumber = 0;
//    int result = 0;
//    int choice = 0;

//    Console.WriteLine("Enter the first number: ");
//    firstNumber = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter the second number: ");
//    secondNumber = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Choose an operation: +, -, *, /");
//    Console.WriteLine("1 - ADD");
//    Console.WriteLine("2 - SUBTRACT");
//    Console.WriteLine("3 - DIVIDE");
//    Console.WriteLine("4 - MULTIPLY");

//    choice = Convert.ToInt32(Console.ReadLine());

//    if (choice == 1)
//    {
//        result = firstNumber + secondNumber;
//        Console.WriteLine("The addition of both numbers is {0}", result);
//    }
//    else if (choice == 2)
//    {
//        result = firstNumber - secondNumber;
//        Console.WriteLine("The subtraction of both numbers is {0}", result);
//    }
//    else if (choice == 3)
//    {
//        result = firstNumber / secondNumber;
//        Console.WriteLine("The division of both numbers is {0}", result);
//    }
//    else if (choice == 4)
//    {
//        result = firstNumber * secondNumber;
//        Console.WriteLine("The multiplication of both numbers is {0}", result);
//    }
//    else
//    {
//        Console.WriteLine("Invalid choice");
//    }


//}

CalculatorApp();

void CalculatorApp()
{
    try
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the operation
        Console.Write("Enter the operation (+, -, *, /): ");

        // Keyboard input is by default of type 'string'
        // and requires conversion to 'char' to work
        // with the switch statement
        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        // Perform the operation
        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException ex)
    {
        // Handle the case where the input is not valid
        Console.WriteLine("Please enter a valid number.");
    }
    catch (DivideByZeroException ex)
    {
        // Handle the divide by zero error
        Console.WriteLine($"You cannot divide by zero.");
    }
    finally
    {
        // This block runs no matter what
        Console.WriteLine("Operation completed.");
    }
}