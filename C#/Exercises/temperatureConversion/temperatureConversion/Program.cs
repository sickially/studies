Console.WriteLine("Temperature Conversion: \n");

Console.WriteLine("Please enter a temperature in Celsius: ");
int c = Convert.ToInt32(Console.ReadLine());

int f = (c * 9/5) + 32;

Console.Write(f);
Console.ReadKey();