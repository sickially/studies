Console.WriteLine("Age Calculator: \n");


Console.WriteLine("What's your year of birth?");
int year = Convert.ToInt32(Console.ReadLine());

int age = 2026 - year;

Console.WriteLine("You are " + age + " Old.");
Console.ReadKey();