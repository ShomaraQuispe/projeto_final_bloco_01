using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produto
    {
        private float preco;
        private string nomeDoProduto;
        private int id, tipo;

        public Produto(float preco, string nomeDoProduto, int id, int tipo)
        {
            this.preco = preco;
            this.nomeDoProduto = nomeDoProduto;
            this.id = id;
            this.tipo = tipo;
        }

        public float GetPreco() { return preco; }
        public void SetPreco(float preco) { this.preco = preco; }
        public string GetNomeDoProduto() { return nomeDoProduto; }
        public void SetNomeDoProduto(string nomeDoProduto) { this.nomeDoProduto = nomeDoProduto; }
        public int GetId() { return id; }
        public void SetId(int id) { this.id = id; }
        public int GetTipo() { return tipo; }
        public void SetTipo(int tipo) { this.tipo = tipo; }

        public virtual void Visualizar()
        {
            string tipo = "";

            switch (this.tipo)
            {
                case 1:
                    tipo = "Vestimenta";
                    break;
                case 2:
                    tipo = "Calçado";
                    break;
            }
            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados do Produto:");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Identificador do Produto: " + this.id);
            Console.WriteLine("Nome do Produto: " + this.nomeDoProduto);
            Console.WriteLine("Preço do Produto: " + this.preco);
            Console.WriteLine("Tipo do Produto: " + tipo);
        }
    }
}
