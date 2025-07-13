using System;

namespace DesafioCSharp
{
    class Somatorio
    {
        private void Somar()
        {
            int soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos números de 1 até 10 é: {soma}");
        }

        public void Executar()
        {
            Console.WriteLine("Soma dos números de 1 até 10");
            Somar();

        }
    }
}
