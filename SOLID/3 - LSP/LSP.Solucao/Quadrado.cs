﻿namespace SOLID.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException(message: "Os dois lados do quadrado precisam ser iguais");
        }
    }
}