namespace SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
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
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}
