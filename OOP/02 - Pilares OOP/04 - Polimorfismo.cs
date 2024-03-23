namespace OOP
{
    // Polimorfismo
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int votagem) : base(nome, votagem){ }

        public CafeteiraExpressa() : base(nome: "Padrão", voltagem:220){ }

        private static void AquecerAgua() { }
        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Testar()
        {
            // Teste do equipamento
        }

        public override void Desligar()
        {
            // Verificar recipiente de agua
        }

        public override void Ligar()
        {
            // Resfriar aquecedor
        }
    }
}
