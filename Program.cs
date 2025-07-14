using System;

namespace DesafioCSharp
{
    class Program
    {
        private static int numLista;

        static void Main()
        {

            Console.WriteLine("  1. Somatorio.cs" +
                            "\n  2. CalculadoraIMC.cs" +
                            "\n  3. Calculadora.cs");
            numLista = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (numLista)
            {
                case 1:
                    Console.WriteLine("Somatorio dos números de 1 até 10");
                    Console.WriteLine();
                    var somatorio = new Somatorio();
                    somatorio.Executar();
                    break;

                case 2:
                    Console.WriteLine("Calculo do Índice de Massa Corporal(IMC)");
                    Console.WriteLine();
                    var calculadoraIMC = new CalculadoraIMC();
                    calculadoraIMC.Executar();
                    break;

                case 3:

                    Console.WriteLine("Calculadora");
                    Console.WriteLine();
                    var calculadora = new Calculadora();
                    calculadora.Executar();
                    break;

                default: Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
}





