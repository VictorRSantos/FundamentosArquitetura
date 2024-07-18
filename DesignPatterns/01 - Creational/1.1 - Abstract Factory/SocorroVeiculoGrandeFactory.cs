namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {      
        public override Guincho CriarGuincho() =>
            GuinchoCreator.Criar(Porte.Grande);

        public override Veiculo CriarVeiculo(string modelo, Porte porte)=>
            VeiculoCreator.Criar(modelo, porte);
    }
}
