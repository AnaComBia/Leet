using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Frase que você quer traduzir para a linguagem leet Speak: ");
            string tradução = Console.ReadLine()
            .Replace("a", "4")
            .Replace("A", "4")
            .Replace("e", "3")
            .Replace("E", "3")
            .Replace("i", "1")
            .Replace("I", "1")
            .Replace("l", "1")
            .Replace("t", "7")
            .Replace("T", "7")
            .Replace("s", "5")
            .Replace("o", "0")
            .Replace("O", "0")
            .Replace("S", "5");

            Console.Write($"\nFrase em Leet Speak: {tradução}\n");
            




            
        }
    }
}
