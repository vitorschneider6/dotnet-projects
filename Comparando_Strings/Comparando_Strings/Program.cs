using System;
using System.Text;

namespace Comparando_Strings;

class App
{
    static void Main(string[] args)
    {
        var text = "Test oi";

        // Compara as duas Strings: 0 se for igual, 1 caso contrário
        Console.WriteLine(text.CompareTo("Test"));
        Console.WriteLine("--------------------------");
        // Verifica se a string possui algum caractere ou palavra indicada (case sensitive)
        Console.WriteLine(text.Contains("e"));
        Console.WriteLine(text.Contains("E"));
        Console.WriteLine("--------------------------");
        // Ignora o case sensitive
        Console.WriteLine(text.Contains("E", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("--------------------------");
        Console.WriteLine(text.StartsWith("Test"));
        Console.WriteLine(text.StartsWith("oi"));
        Console.WriteLine(text.StartsWith("test"));
        Console.WriteLine(text.EndsWith("oi"));

        // Verifica se o objeto é igual ao invés de ser uma string
        Console.WriteLine("--------------------------");
        Console.WriteLine(text.Equals("Test oi"));

        Console.WriteLine("--------------------------");
        Console.WriteLine(text.IndexOf("t"));
        Console.WriteLine(text.LastIndexOf("s"));

        var texto = new StringBuilder();
        texto.Append("Meu");
        texto.Append("nome");
        texto.Append("é");
    }
}