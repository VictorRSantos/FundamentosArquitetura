﻿namespace OOP
{
    // Definação de classe
    public class Casa
    {
        public int TamanhhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            // Definição de Objeto
            var casa = new Casa
            {
                TamanhhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };

        }
    }
}
