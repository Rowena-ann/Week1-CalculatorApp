//// first number 
//int firstNumber = 5;
//// second number
//int secondNumber = 10;

//int result = firstNumber + secondNumber;
//Console.WriteLine("The addition of both numbers is {0}", result);
//Console.ReadKey();


// now we get input from the user
Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("The addition of both numbers is {0}", result);

