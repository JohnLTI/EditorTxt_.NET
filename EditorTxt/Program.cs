using System;

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
            short opt = short.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
        }

        static void Editar()
        {
            Console.Clear();
        }
    }
}
