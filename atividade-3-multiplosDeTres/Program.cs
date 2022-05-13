using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 03 - Multiplos de tres");

        for (int i = 3; i <= 100; i += 3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}