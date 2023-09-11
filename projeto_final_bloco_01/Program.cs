using projeto_final_bloco_01.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using projeto_final_bloco_01.Controller;

namespace projeto_final_bloco_01
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao, tipo, numero, tamanhoCalcado;
            string? nome, tamanhoRoupa, cor;
            float preco;

            ProdutoController produtos = new();

            //Produtos Pré-Cadastrados
            Roupa r1 = new Roupa(90, "Vestido", produtos.GerarNumero(), 1, "Amarelo", "P");
            produtos.CriarProduto(r1);

            Calcado c1 = new Calcado(150, "Bota", produtos.GerarNumero(), 2, 36);
            produtos.CriarProduto(c1);

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("     Lojinha da Shomara | Moda Feminina      ");
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
                    Console.WriteLine("\nLojinha da Shomara | Moda Feminina");
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

                        Console.WriteLine("Digite o preço do Produto: ");
                        preco = Convert.ToSingle(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Digite o Tipo do Produto: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o Tamanho do produto: ");
                                tamanhoRoupa = Console.ReadLine();

                                Console.WriteLine("Digite a Cor do produto: ");
                                cor = Console.ReadLine();

                                tamanhoRoupa ??= string.Empty;
                                produtos.CriarProduto(new Roupa(preco, nome, produtos.GerarNumero(), tipo, cor, tamanhoRoupa));
                                break;

                            case 2:
                                Console.WriteLine("Digite o Tamanho do produto: ");
                                tamanhoCalcado = Convert.ToInt32(Console.ReadLine());

                                produtos.CriarProduto(new Calcado(preco, nome, produtos.GerarNumero(), tipo, tamanhoCalcado));
                                break;
                        }
                        Keypress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todos os Produtos\n");
                        Console.ResetColor();

                        produtos.ListarTodosProdutos();

                        Keypress();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar Produto por ID\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do ID do Produto: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        produtos.ConsultaProdutoID(numero);

                        Keypress();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar Dados do produto\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do ID do produto: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        var produto = produtos.BuscarIdNaCollection(numero);

                        if (produto is not null)
                        {
                            Console.WriteLine("Digite o Nome do produto: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite o Preço do produto ");
                            preco = Convert.ToSingle(Console.ReadLine());

                            nome ??= string.Empty;

                            tipo = produto.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o Tamanho do produto: ");
                                    tamanhoRoupa = Console.ReadLine();

                                    Console.WriteLine("Digite a Cor do produto: ");
                                    cor = Console.ReadLine();

                                    tamanhoRoupa ??= string.Empty;
                                    produtos.Atualizar(new Roupa(preco, nome, produto.GetId(), tipo, cor, tamanhoRoupa));
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o Tamanho do produto: ");
                                    tamanhoCalcado = Convert.ToInt32(Console.ReadLine());

                                    produtos.Atualizar(new Calcado(preco, nome, produto.GetId(), tipo, tamanhoCalcado));
                                    break;
                            }
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"o ID do produto {numero} não foi encontrado!");
                            Console.ResetColor();
                        }


                        Keypress();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar Produto\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do ID do produto que deseja apagar: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        produtos.Deletar(numero);

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