using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 08 - Condicionais2.");

        int idadeRafael = 17;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        bool grupo = true;

        if (idadeRafael >= 18 || acompanhado) 
        {
            Console.WriteLine("Ponde entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.Write("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
