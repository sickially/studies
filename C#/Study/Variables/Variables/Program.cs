Console.WriteLine("Variables in C#!\n");

int x; // Declaration
x = 123; // Initialization

int y = 321; // Declaration & Initialization

int z = x + y;

int age = 21; // int -> whole integer
double height = 300.5; // decimal number
bool alive = false; // True or False
char symbol = '@'; //
String name = "Valerie";

Console.WriteLine("Hello " + name); 
Console.WriteLine("Your age is " + age);
Console.WriteLine("Your height is " + height + "cm");
Console.WriteLine("Are you alive? " + alive);
Console.WriteLine("Your symbol is " + symbol);

String userName = symbol + name;

Console.WriteLine("Your username is " + userName);

Console.ReadKey();