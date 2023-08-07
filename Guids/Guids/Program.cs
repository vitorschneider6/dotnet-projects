using System;

namespace Guids;

class App
{
    static void Main(string[] args)
    {
        // Gera um conjunto de 36 caracteres aleatórios único
        var id = Guid.NewGuid();
        Console.WriteLine(id);
        // Estancia um objeto Guid com o guid gerado anterior
        id = new Guid(id.ToString());
        Console.WriteLine(id.ToString().Substring(0, 8));
    }
}