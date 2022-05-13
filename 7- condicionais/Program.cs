using System;

class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 07 - Condicionais.");

        int idadeRafael = 17;
        int quantidadePessoas = 2;

        if (idadeRafael >= 18)
        {
            Console.WriteLine("Ponde entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");

            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, Pode entrar...");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
        }

        Console.Write("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}