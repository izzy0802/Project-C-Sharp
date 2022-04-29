using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Banco 
    {
        int contador = 0;
        ContaCorrente[] conta = new ContaCorrente[20];
        public int criarConta(bool especial, double limite, double saldo)
        {
            ContaCorrente conta1 = new ContaCorrente(especial, limite, saldo);
            conta[contador] = conta1;
            contador++;
            return conta[contador-1].getNumero();
        }
        public bool depositar(int numero, double dinheiro)
        {
            ContaCorrente conta1 = localizarConta(numero);
            if (conta1 != null)
            {
                Console.WriteLine("Seu saldo atual");
                Console.WriteLine(conta1.getSaldo());
                double teste = conta1.getSaldo() + dinheiro;
                if (teste > conta1.geLimite())
                {
                    return false;
                }
                conta1.depositar(teste);
                return true;
            }
            return false;
            
        }
        public bool excluirConta(int numero)
        {
            ContaCorrente conta1 = localizarConta(numero);
            if (conta != null)
            {
                conta[conta1.getNumero() - 1] = null;
                return true;
            }
            return false;
        }
        private ContaCorrente localizarConta(int numero)
        {
            
            if (conta[numero-1]!=null) 
            {
                return conta[numero - 1];
            }
            return null;


        }
        public bool sacar(int numero,double dinheiro)
        {
            ContaCorrente conta1 = localizarConta(numero);
            if(conta1 != null)
            {
                Console.WriteLine("Saldo atual");
                Console.WriteLine(conta1.getSaldo());
                if (conta1.getSaldo()>0 && conta1.getSaldo()>=dinheiro)
                {
                    conta1.sacar(dinheiro);
                    return true;
                }
                Console.WriteLine("Não a saldo o suficiente");
                return false;
            }
            Console.WriteLine("Conta não localizada");
            return false;
        }
        public bool transferir(int numero1, int numero2,double dinheiro)
        {
            ContaCorrente conta1 =  localizarConta(numero1);
            ContaCorrente conta2 = localizarConta(numero2);
            if(conta1!= null && conta2 != null)
            {
                Console.WriteLine("Saldo atual da primeira conta");
                if (conta1.sacar(dinheiro))
                {
                    conta2.depositar(dinheiro);
                }
                Console.WriteLine("Saldo após a transferencia da primeira conta");
                Console.WriteLine(conta1.getSaldo());
                Console.WriteLine("Saldo após a transferencia da segunda conta");
                Console.WriteLine(conta2.getSaldo());
                return true;
            }
            Console.WriteLine("Conta não localizada");
            return false;
        }


    }
}