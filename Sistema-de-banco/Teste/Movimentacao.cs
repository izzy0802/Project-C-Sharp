using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Banco { };
namespace Teste
{
    public class Movimentacao
    {
        private String descricao;
        private char tipo;
        private double valor;

        public Movimentacao(String descricao, double valor)
        {
            this.descricao = descricao;
            this.tipo = valor > 0 ? 'C' : 'D';
            this.valor = valor;
        }
        public String extrato()
        {
            return this.descricao + " R$" + this.valor;
        }
    }
}
