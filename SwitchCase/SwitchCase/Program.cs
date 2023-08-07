using System;
using System.Security.Cryptography.X509Certificates;

class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type a name:");
        string nome = Console.ReadLine();

        switch (nome)
        {
            case "Carlos":
                Console.WriteLine("It's not the man!");;
                break;
            case "John":
                Console.WriteLine("It's the man!");
                break;
            default:
                Console.WriteLine("We can't find the guy!");
                break;
        }

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

    }

    static int soma(int x, int y) 
    {
        return x + y;
    }
}