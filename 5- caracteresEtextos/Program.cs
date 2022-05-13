using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e textos.");

        char letra;
        
        letra = (char) 66;
        Console.WriteLine(letra);

        letra = (char) 82;
        Console.WriteLine(letra);

        letra = (char)85;
        Console.WriteLine(letra);

        letra = (char)78;
        Console.WriteLine(letra);

        letra = (char)79;
        Console.WriteLine(letra);

        letra = (char)66;
        Console.Write(letra);

        letra = (char)82;
        Console.Write(letra);

        letra = (char)85;
        Console.Write(letra);

        letra = (char)78;
        Console.Write(letra);

        letra = (char)79;
        Console.WriteLine(letra);

        letra = (char) (65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Senai - Curso de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Curso disponíveis: 
-C 
-C++ 
-HTML 
-CSharp";
        Console.WriteLine(cursos);

        Console.Write("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}