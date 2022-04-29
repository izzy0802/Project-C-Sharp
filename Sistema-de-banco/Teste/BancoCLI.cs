using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class BancoCLI
    {
        private Banco Banco;

    public BancoCLI()
        {
            Banco = new Banco();
            mostrarMenu();
        }
        public void mostrarMenu()
        {

            String opcoes = "Menu principal do banco";
            opcoes += "\n 1 - criar conta";
            opcoes += "\n 2 - depositar";
            opcoes += "\n 3 - sacar";
            opcoes += "\n 4 - transferir";
            opcoes += "\n 5 - finalizar";

            char opcao;
            do
            {
                Console.WriteLine(opcoes);
                Console.WriteLine("Escolha uma opçao");
                opcao = char.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case '1': this.criarConta(); break;
                    case '2': this.depositar(); break;
                    case '3': this.sacar(); break;
                    case '4': this.transferir(); break;
                    case '5': this.finalizar(); break;
                }
            } while (opcao != '5');

        }

        public void criarConta()
        {
            Console.WriteLine("Criação de conta");
            Console.WriteLine("Conta especial[s / n]");
            bool especial = char.Parse(Console.ReadLine()) == 's';
            Console.WriteLine("Digite o saldo Inicial");
            double saldoInicial = double.Parse(Console.ReadLine());
            double limite = 500;
            if (especial)
            {
                Console.WriteLine("Digite o limite");
                limite = double.Parse(Console.ReadLine());
            }
            this.Banco.criarConta(especial, limite, saldoInicial);
        }

        public void depositar()
        {
            Console.WriteLine("Deposito sendo executado");
            Console.WriteLine("Digite o numero da conta a ser depositado");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantia a ser depositada");
            double dinheiro = double.Parse(Console.ReadLine());
            this.Banco.depositar(numero, dinheiro);
        }

        public void sacar()
        {
            Console.WriteLine("Saque em execução");
            Console.WriteLine("Digite o numero da conta");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dinehiro a ser sacado");
            double dinheiro = double.Parse(Console.ReadLine());
            this.Banco.sacar(numero, dinheiro);
        }

        public void transferir()
        {

            Console.WriteLine("Transferencia em execução");
            Console.WriteLine("Digite o numero da primeira conta cujo valor será removido");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da segunda conta cujo valor será acrescentado");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da transferencia");
            double dinheiro = double.Parse(Console.ReadLine());
            this.Banco.transferir(numero1, numero2, dinheiro);
        }
        public void finalizar()
        {
            
        }
    }
}
