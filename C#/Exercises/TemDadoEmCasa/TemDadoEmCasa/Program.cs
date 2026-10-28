Console.WriteLine("Você tem dado em casa? \n");
Random random = new Random();

int dice = random.Next(1, 6);
int dice2 = random.Next(1, 6);

Console.WriteLine("Gire o dado! Pegue uma carta e seu número é: " + dice);
Console.WriteLine("O outro dado deu: " + dice2);

Console.ReadKey();