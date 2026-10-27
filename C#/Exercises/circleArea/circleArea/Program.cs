Console.WriteLine("Circle Area:\n");

Console.WriteLine("Input a decimal value for radius: ");
const double pi = 3.14159;
double radius = Convert.ToDouble(Console.ReadLine());
double power = Math.Pow(radius, 2);

double area = pi * power;
Console.WriteLine("Total: " + area );

Console.ReadKey();