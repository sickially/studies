Console.WriteLine("Personal Info:\n");

Console.WriteLine("What's your name?");
String name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What's your height?");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height + 0.1);

Console.ReadKey();