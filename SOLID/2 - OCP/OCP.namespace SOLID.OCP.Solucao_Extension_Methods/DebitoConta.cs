﻿namespace SOLID.OCP.Solucao_Extension_Methods
{
    public class DebitoConta
    {
        public string? NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string? NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Número de transação formatado
            return NumeroTransacao;
        }
    }
}
