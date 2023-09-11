using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Roupa : Produto
    {
        private string cor, tamanho; 
        public Roupa(float preco, string nomeDoProduto, int id, int tipo, string cor, string tamanho) : 
            base(preco, nomeDoProduto, id, tipo)
        {
            this.cor = cor;
            this.tamanho= tamanho;
        }

        public string GetCor() { return this.cor; }
        public void SetCor(string cor) { this.cor = cor; }
        public string GetTamanho() {  return this.tamanho; }
        public void SetTamanho(string tamanho) { this.tamanho = tamanho; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Cor do Produto: " + this.cor);
            Console.WriteLine("Tamanho do Produto: " +  this.tamanho);
        }
    }
}
