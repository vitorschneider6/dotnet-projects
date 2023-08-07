using System;
using System.Globalization;

namespace Moedas;

class Program
{
    static void Main(string[] args)
    {
        decimal value = 10221.2m;
        var data = DateTime.Now;

        Console.WriteLine(data.ToString("tt"));

        Console.WriteLine(value.ToString("C"));
    }
}