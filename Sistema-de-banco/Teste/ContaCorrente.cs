using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ContaCorrente 
    {
        protected Movimentacao[] movimentacao;
        private static int totalContas;
        private bool especial;
        private double limite;
        private static int numero = 0;
        private double saldo;

        public ContaCorrente(bool especial, double limite, double saldo)
        {
            this.especial = especial;
            this.limite = limite;
            this.saldo = saldo;
            numero++;
            Console.WriteLine("O numero de sua nova conta é: " +numero);
            this.movimentacao = new Movimentacao[9999];
            CriarMovimentacao("saldo inicial", saldo);
            
        }
        public ContaCorrente() { }
        public void setEspecial(bool especial)
        {
            this.especial = especial;
        }
        public void setLimite(double limite)
        {
            this.limite = limite;
        }
        public double geLimite()
        {
            return limite;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public int getNumero()
        {
            return numero;
        }
        private void CriarMovimentacao(string descricao, double valor)
        {
            Movimentacao movimentacao1 = new Movimentacao(descricao,valor);
            for (int x = 0; x < 9999; x++)
            {
                if (movimentacao[x] == null)
                {
                    movimentacao[x] = movimentacao1;
                    break;
                }
            }

        }
        public void depositar(double dinheiro)
        {
            saldo = saldo + dinheiro - saldo;
            Console.WriteLine("Saldo com o deposito efetuado");
            Console.WriteLine(saldo);
        }
        public bool sacar(double dinheiro)
        {
            saldo = saldo - dinheiro;
            Console.WriteLine("Saldo com o saque efetuado");
            Console.WriteLine(saldo);
            return true;
        } 
        public static int getTotalContas()
        {
            return totalContas;
        }
        public Movimentacao[] getMovimentacao()
        {
            return movimentacao;
        }
    }

}
