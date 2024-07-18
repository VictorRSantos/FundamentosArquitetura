namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {      
        public override Guincho CriarGuincho() =>
            GuinchoCreator.Criar(Porte.Medio);

        public override Veiculo CriarVeiculo(string modelo, Porte porte)=>
            VeiculoCreator.Criar(modelo, porte);
    }
}
