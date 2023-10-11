string mensagemDeBoasVindas = "Bem vindo ao Spotify";

// List<string> listaDasBandas = new List<string>{"U2", "The Beatles", "Aerosmith"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> {10, 9, 6});
bandasRegistradas.Add("The Beatles", new List<int>());



void ExibirLogo()
{
    Console.WriteLine(@"
████████████████████████████████████████
█─▄▄▄▄█▄─▄▄─█─▄▄─█─▄─▄─█▄─▄█▄─▄▄─█▄─█─▄█
█▄▄▄▄─██─▄▄▄█─██─███─████─███─▄████▄─▄██
▀▄▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▄▀▀
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\n1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Para avaliar uma banda");
    Console.WriteLine("4 - Para exibir a média de uma banda");
    Console.WriteLine("-1 - Para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   switch(opcaoEscolhidaNumerica)
   {

    case 1 : RegistrarBandas(); 
        break;
    case 2 : MostrarBandasRegistradas(); 
        break;
    case 3 : AvaliarUmaBanda(); 
        break;
    case 4 : Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
        break;
    case -1 : Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
        break;
    default : Console.WriteLine("Opção inválida");
        break;
   }

    void RegistrarBandas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registrar banda");
        Console.Write("Digite o nome da banda que deseja registrar: \n");
        string nomeDaBanda = Console.ReadLine();
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
    {
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas:");
        // for (int i = 0; i < listaDasBandas.Count; i++)
        // {
        //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
        // }
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"banda: {banda}");
        }
        Console.WriteLine("\nDigite alguma tecla para voltar para o menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!; // A interrogação é para forçar a receber apenas uma string
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece:");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota); //o [] foi usado para indexar o produto da lista e depois o .Add para adicionar a nota naquele elemento específico.
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrado");
        Console.WriteLine("Digite uma tecla para voltar ao menu inicial");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}

ExibirOpcoesDoMenu();


// ========== Jogo do acerto ==========
// using System.ComponentModel;

// Console.WriteLine(@"
// ░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗███████╗  ░█████╗░
// ██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔════╝  ██╔══██╗
// ███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║█████╗░░  ██║░░██║
// ██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══╝░░  ██║░░██║
// ██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║███████╗  ╚█████╔╝
// ╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ░╚════╝░

// ███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
// ████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
// ██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
// ██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
// ██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
// ╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░");




// void partida() 
// {

//     Random randNum = new Random();
//     int valorInteiro = randNum.Next(1,11);

//     string opcaoJogador = "";
//     int opcaoJogadorNum = 0;

//     do{

//         Console.WriteLine("Digite seu número entre 1 e 100:\n");
//         opcaoJogador = Console.ReadLine();
//         opcaoJogadorNum = int.Parse(opcaoJogador);

//      } while(opcaoJogadorNum != valorInteiro);
//      if(opcaoJogadorNum == valorInteiro) {
//         Console.WriteLine("Parabéns, o número correto é o " + valorInteiro);
//      }
// }

// partida();