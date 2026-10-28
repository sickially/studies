Console.WriteLine("Grade Average:\n");

Console.WriteLine("Please enter your first grade:");
int firstGrade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second grade:");
int secondGrade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your third grade:");
int thirdGrade = Convert.ToInt32(Console.ReadLine());

int totalGrade = firstGrade + secondGrade + thirdGrade;
double gradeAverage = totalGrade / 3.0;

Console.WriteLine("This is the average of your grades: " + gradeAverage);

Console.ReadKey();