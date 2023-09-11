using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProduto = new List<Produto>();
        int numero = 0;
        public void Atualizar(Produto produto)
        {
            var procurarProduto = BuscarIdNaCollection(produto.GetId());

            if (procurarProduto is not null)
            {
                var index = listaProduto.IndexOf(procurarProduto);

                listaProduto[index] = produto;

                Console.WriteLine($"O Produto do ID {produto.GetId()} foi atualizado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto do ID {produto.GetId()} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ConsultaProdutoID(int numero)
        {
            var produto = BuscarIdNaCollection(numero);
            if (produto is not null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto do ID {numero} não foi encontrado");
                Console.ResetColor();
            }
        }

        public void CriarProduto(Produto produto)
        {
            listaProduto.Add(produto);
            Console.WriteLine($"O Produto com ID {produto.GetId()} foi criado com sucesso!");
        }

        public void Deletar(int numero)
        {
            var produto = BuscarIdNaCollection(numero);

            if (produto is not null)
            {
                if (listaProduto.Remove(produto) == true)
                    Console.WriteLine($"O produto do ID {numero} foi apagado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto do ID {numero} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarTodosProdutos()
        {
            if (listaProduto.Count() > 0)
            {
                foreach (var produto in listaProduto)
                {
                    produto.Visualizar();
                }

            }
            else
            {
                Console.WriteLine("Estamos sem produtos no momento, volte mais tarde!");
            }
        }

        //Métodos Auxiliares
        public int GerarNumero()
        {
            return ++numero;
        }

        public Produto? BuscarIdNaCollection(int numero)
        {
            foreach (var produto in listaProduto)
            {
                if (produto.GetId() == numero)
                    return produto;
            }
            return null;
        }
    }
}
