namespace SOLID.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo ret)
        {
            Console.Clear();
            Console.WriteLine(value:"Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(value:ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadLine();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(altura: 5, largura: 5);

            var ret = new Retangulo(altura: 10, largura: 5);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}
