using System;

namespace Calculator;
class App
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Selecione a opção desejada:");
        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação");
        Console.WriteLine("4- Divisão");
        Console.WriteLine("5- Sair");
        short opcao = short.Parse(Console.ReadLine());
        if(opcao == 5 ) {
            Console.WriteLine("Saindo...");
            System.Environment.Exit(0);
        }
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor:");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        float y = float.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1:
                Soma(x, y);
                break;
            case 2:
                Subtracao(x, y);
                break;
            case 3:
                Multiplicacao(x, y);
                break;
            case 4:
                Divisao(x, y);
                break;
            default:
                Menu();
                break;
        }
    }

    static void Soma(float x, float y)
    {
        float resultado = x + y;

        Console.WriteLine($"O resultado da soma é: {resultado}");
        Menu();
    }
    static void Subtracao(float x, float y)
    {
        float resultado = x - y;

        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Menu();
    }
    static void Multiplicacao(float x, float y)
    {
        float resultado = x * y;

        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Menu();
    }
    static void Divisao(float x, float y)
    {
        float resultado = x / y;

        Console.WriteLine($"O resultado da divisão é: {resultado:F2}");
        Menu();
    }

}