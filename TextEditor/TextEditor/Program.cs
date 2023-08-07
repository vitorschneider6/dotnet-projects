using System;

namespace TextEditor;

class App
{
    static void Main(string[] args)
    {
        Menu();
    }
  
    static void Menu()
    {
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1- Abrir um arquivo");
        Console.WriteLine("2- Criar um novo arquivo");
        Console.WriteLine("0- Sair");
        Console.WriteLine("----------------------");
        short option = short.Parse(Console.ReadLine());

        Console.Clear();    
        switch(option)
        {
            case 1:
                Open();
                break;
            case 2:
                Create();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Menu();
                break;
        }
}
    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Digite o caminho do arquivo que deseja abrir:");
        var path = Console.ReadLine();

        using(var reader =  new StreamReader(path))
        {
            var text = reader.ReadToEnd();
            Console.WriteLine(text);
        }

        Menu();
    }

    static void Create()
    {
        string text = "";
        Console.WriteLine("Digite o texto a ser salvo:");
        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.Clear();
        Salvar(text);
    }

    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Onde você deseja salvar o arquivo .txt?");
        var path = Console.ReadLine();

        using(var writer = new StreamWriter(path))
        {
            writer.Write(text);
        }

        Console.WriteLine($"Arquivo salvo com sucesso no caminho: {path}");
        Menu();
    }
}