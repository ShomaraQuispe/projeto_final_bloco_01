using projeto_final_bloco_01.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace projeto_final_bloco_01
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao, tipo, numero;
            string? nome;
            decimal preco;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("             Lojinha da Shomara              ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("         1 - Cadastrar Produto               ");
                Console.WriteLine("         2 - Listar todos os Produtos        ");
                Console.WriteLine("         3 - Consultar Produto por ID        ");
                Console.WriteLine("         4 - Atualizar Produto               ");
                Console.WriteLine("         5 - Deletar Produto                 ");
                Console.WriteLine("         6 - Sair                            ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("Entre com a opção desejada:                  ");
                Console.WriteLine("                                             ");
                Console.ResetColor();


                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nDigite um valor inteiro entre 1 e 6");
                    opcao = 0;
                    Console.ResetColor();
                }

                if (opcao == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nLojinha da Shomara");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cadastrar Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o nome do Produto: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                        Console.WriteLine("Digite o tipo do Produto: ");
                        tipo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o preço do Produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        Keypress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todos os Produtos\n");
                        Console.ResetColor();


                        Keypress();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar Produto por ID\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do ID do Produto: ");
                        numero = Convert.ToInt32(Console.ReadLine());


                        Keypress();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar Dados do produto\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do ID do produto: ");
                        numero = Convert.ToInt32(Console.ReadLine());



                        Keypress();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar Produto\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do ID do produto que deseja apagar: ");
                        numero = Convert.ToInt32(Console.ReadLine());


                        Keypress();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        Keypress();
                        break;

                }

                static void Sobre()
                {
                    Console.WriteLine("\n******************************************");
                    Console.WriteLine("                                            ");
                    Console.WriteLine("Projeto desenvolvido por: Shomara Quispe");
                    Console.WriteLine("shomaraclaudia@gmail.com");
                    Console.WriteLine("github.com/ShomaraQuispe");
                    Console.WriteLine("                                            ");
                    Console.WriteLine("********************************************");
                }

                static void Keypress()
                {
                    do
                    {
                        Console.Write("\nPressione Enter para continuar");
                        consoleKeyInfo = Console.ReadKey();
                    } while (consoleKeyInfo.Key != ConsoleKey.Enter);
                }

            }
        }

    }
}