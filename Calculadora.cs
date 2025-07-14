using System;

namespace DesafioCSharp
{
    class Calculadora
    {
        private double numUm;
        private double numDois;
        private int operacao;
        private double resultado;
        private void ReceberDados()
        {
            try {
                Console.Write("Digite o 1° Número ");
                numUm = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o 2° Número ");
                numDois = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("  1. Soma" +
                                "\n  2. Subtração" +
                                "\n  3. Multiplicação" +
                                "\n  4. Divisão");
                operacao = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida.");
                ReceberDados();
            }
        }

        private void Calcular()
        {
            switch (operacao)
            {
                case 1:
                    resultado = numUm + numDois;
                    Console.WriteLine($"Resultado da Soma: {resultado}");
                    break;
                case 2:
                    resultado = numUm - numDois;
                    Console.WriteLine($"Resultado da Subtração: {resultado}");
                    break;
                case 3:
                    resultado = numUm * numDois;
                    Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                    break;
                case 4:
                    resultado = numUm / numDois;
                    Console.WriteLine($"Resultado da Divisão: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        public void Executar() { 
        
            ReceberDados();
            Calcular();
        }
    }
}
