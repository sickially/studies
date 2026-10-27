Console.WriteLine("Basic Calculator: \n");

Console.WriteLine("Input your first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\ninput your second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int totalAddition = num1 + num2;
int totalSubtraction = num1 - num2;
int totalMultiplication = num1 * num2;
int totalDivision = num1 / num2;

Console.WriteLine("Addition: " + totalAddition);
Console.WriteLine("Subtraction: " + totalSubtraction);
Console.WriteLine("Multiplication: " + totalMultiplication);
Console.WriteLine("Division: " + totalDivision);

Console.ReadKey();