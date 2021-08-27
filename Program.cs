using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
        string textoDigitado;
        Console.Write("Digite um texto e eu o traduzirei para o Leet: ");
           textoDigitado = Console.ReadLine()
           .Replace("a","4")
           .Replace("A","4")
           .Replace("e","3")
           .Replace("E","3")
           .Replace("i","1")
           .Replace("I","1")
           .Replace("l","1")
           .Replace("L","1")
           .Replace("o","0")
           .Replace("O","0")
           .Replace("t","7")
           .Replace("T","7")
           .Replace("s","5")
           .Replace("S","5");
           Console.Write("TEXTO TRADUZIDO: ");
           Console.WriteLine(textoDigitado);
        }
    }
}
