namespace SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Valida Aniversario da Conta
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}
