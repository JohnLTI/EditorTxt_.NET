using System;
using System.Threading;

namespace EditorTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----Seja Bem-vindo!-----");
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo de texto");
            Console.WriteLine("2 - Criar novo arquivo de texto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            short opt = short.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: Saida(); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto logo abaixo (ESC para sair)");
            Console.WriteLine("---------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape); // verificando se a tecla apertada é diferente de ESC (Escape)

            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.Write(texto);
            Thread.Sleep(3000);
            Menu();

        }
        static void Saida()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o editor de texto!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            System.Environment.Exit(0);

        }
    }
}
