using System;

namespace Stopwatch;

class App
{
    static void Main(string[] args) {
        Menu();
        
    }

    static void Menu()
    {
        Console.WriteLine("Escolha o tempo desejado:");
        Console.WriteLine("S - Segundos (10s => 10 segundos)");
        Console.WriteLine("M - Minutos (1m => 1 minuto)");
        Console.WriteLine("0 - Sair");

        string time = Console.ReadLine().ToLower();
        char option = char.Parse(time.Substring(time.Length - 1, 1));
        int tempo = int.Parse(time.Substring(0, time.Length - 1));
        

        switch(option)
        {
            case 's':
                PreStart(tempo);
                break;
            case 'm':
                PreStart(tempo * 60);
                break;
            case '0':
                Console.WriteLine("Finalizando..."); 
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Menu();
                break;
        }
    }

    static void PreStart(int time)
    {
        Console.Clear();

        Console.WriteLine("Starting.");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Starting..");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Starting...");
        Thread.Sleep(1000);
        Console.Clear();
        Start(time);

    }

    static void Start(int time)
    {
        int currentTime = 0;

        while(currentTime < time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Finalizado!");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }
}