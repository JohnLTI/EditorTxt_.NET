using System;
using System.IO;
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
            Console.WriteLine("Qual o caminho do arquivo?");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("Digite qualquer tecla para voltar ao Menu Inicial!");
            Console.ReadKey();
            Menu();
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

            Salvar(texto);
            Menu();
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("QQual o caminho para salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho)) //cria e fecha qualquer arquivo aberto nesta ferramenta
            {
                arquivo.Write(texto);
            }

            Console.WriteLine("");
            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            Console.WriteLine("Digite uma tecla para voltar ao Menu Inicial!");
            Console.ReadKey();
            Menu();
        }
        static void Saida()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o editor de texto!");
            Console.WriteLine("");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }
    }
}
