namespace SOLID.OCP.Solucao_Extension_Methods
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {
            MenuOperacoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;

            var debitoConta = DadosDebito();

            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine(value: "Efetuando operação em Conta Corrente");
                    retorno = debitoConta.DebitarContaCorrente();
                    break;
                case '2':
                    Console.WriteLine(value: "Efetuando operação em Conta Popança");
                    retorno = debitoConta.DebitarContaPoupancao();
                    break;
                case '3':
                    Console.WriteLine(value: "Efetuando operação em Conta Investimento");
                    retorno = debitoConta.DebitarContaInvestimento();
                    break;
            }

            RetornoTransacao(retorno);
        }

        private static void MenuOperacoes()
        {
            Console.Clear();
            Console.WriteLine(value: "Caixa Eletrônico SOLID");
            Console.WriteLine(value: "Escolha sua opção:");
            Console.WriteLine();
            Console.WriteLine(value: "1 - Saque Conta Corrente");
            Console.WriteLine(value: "2 - Saque Conta Poupança");
            Console.WriteLine(value: "3 - Saque Conta Investimento");
        }
        private static DebitoConta DadosDebito()
        {
            Console.WriteLine();
            Console.WriteLine(value: "..............................");
            Console.WriteLine();
            Console.WriteLine(value: "Digite a Conta");
            var conta = Console.ReadLine();
            Console.WriteLine(value: "Digite o Valor");
            var valor = Convert.ToDecimal(Console.ReadLine());

            var debitoConta = new DebitoConta()
            {
                NumeroTransacao = conta,
                Valor = valor
            };

            return debitoConta;
        }
        private static void RetornoTransacao(string retorno)
        {
            Console.WriteLine();
            Console.WriteLine(value: "Sucesso! Transação: " + retorno);
            Console.ReadKey();
        }
    }
}
