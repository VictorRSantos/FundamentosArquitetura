namespace SOLID.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupancao(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta poupança
            return debitoConta.FormatarTransacao();
        }
    }
}
