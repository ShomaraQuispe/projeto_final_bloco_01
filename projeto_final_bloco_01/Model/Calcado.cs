using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Calcado : Produto
    {
        private int tamanhoCalcado;
        public Calcado(float preco, string nomeDoProduto, int id, int tipo, int tamanhoCalcado) : base(preco, nomeDoProduto, id, tipo)
        {
            this.tamanhoCalcado = tamanhoCalcado;
        }

        public int GetTamanhoCalcado() { return tamanhoCalcado; }
        public void SetTamanhoCalcado(int tamanhoCalcado) { this.tamanhoCalcado= tamanhoCalcado; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Tamanho do Calçado: " + this.tamanhoCalcado);
        }
    }
}
