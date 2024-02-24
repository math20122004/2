Random dice = new();

Console.Clear();
Console.WriteLine("############# O JOGO COMEÇOU #############\n");

int dice01 = dice.Next(1, 7);
Console.WriteLine($"Dado 1: {dice01}");
Thread.Sleep(2000);

int dice02 = dice.Next(1, 7);
Console.WriteLine($"Dado 2: {dice02}");
Thread.Sleep(2000);

int dice03 = dice.Next(1, 7);
Console.WriteLine($"Dado 3: {dice03}");
Thread.Sleep(2000);

int somaDices = dice01 + dice02 + dice03;

Console.WriteLine($"A soma dos dados são {somaDices}.\n");
Thread.Sleep(1000);

if(dice01 == dice02 || dice01 == dice03 || dice03 == dice02 ){
    Console.Clear();
    Console.WriteLine("PARABÉNS VOCÊ GANHOU MAIS 2 DADOS!!");
    Console.WriteLine("\nRodando dados:");

    int dice04 = dice.Next(1, 7);
    Console.WriteLine($"Dado 4: {dice04}");
    Thread.Sleep(2000);

    int dice05 = dice.Next(1, 7);
    Console.WriteLine($"Dado 5: {dice05}");
    Thread.Sleep(2000);

    somaDices += dice04 + dice05;
    Console.WriteLine($"\nO novo valor é: {somaDices}");
}


