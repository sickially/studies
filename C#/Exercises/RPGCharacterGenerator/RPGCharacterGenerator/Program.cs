Random random = new Random();

Console.WriteLine("Create your character: ");

Console.WriteLine("Please enter your name: ");
string charName = Console.ReadLine();

int charPower = random.Next(1, 20);
int charAgility = random.Next(1, 20);
const int hitPoints = 100;
double statusAverage = (charPower + charAgility) / 2.0;

Console.WriteLine("Welcome to a new world of fantasy!!");
Console.WriteLine("Name: " + charName);
Console.WriteLine("Power: " + charPower);
Console.WriteLine("Agility: " + charAgility);
Console.WriteLine("HP: " + hitPoints);
Console.WriteLine("Status Average: " + statusAverage);

Console.ReadKey();