Console.WriteLine(@"
░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗███████╗  ░█████╗░
██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔════╝  ██╔══██╗
███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║█████╗░░  ██║░░██║
██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══╝░░  ██║░░██║
██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║███████╗  ╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ░╚════╝░

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░");

bool condition = false;
Random random = new Random();
int valorNumerico = random.Next(0, 101);

while (!condition)
{
    Console.Write("Como jogar: O programa vai escolher um número aleatório de 0 a 100, você deve tentar adivinhar qual é: ");
    Console.Write("Escolha um número: ");
    String chute = Console.ReadLine();
    int chuteConvertido = int.Parse(chute);
    if(chuteConvertido > valorNumerico)
    {
        Console.WriteLine($"{chuteConvertido} é maior que o número.");
    }else if(chuteConvertido < valorNumerico)
    {
        Console.WriteLine($"{chuteConvertido} é menor que o número.");
    }else if(chuteConvertido == valorNumerico) {
        Console.WriteLine($"{chuteConvertido} é igual ao número sorteado: {valorNumerico}.");
        Console.WriteLine("Até...");
        condition = true;
    }
}