using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 09 - Escopo.");

        int idadeRafael = 17;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = ("Rafael está acompanhado!");
        }
        else
        {
            textoAdicional = ("Rafael não está acompanhado!");
        }
        if(idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Poade entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        Console.Write("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}