using System;

namespace DesafioCSharp
{
    class CalculadoraIMC
    {
        private double peso;
        private double altura;
        private double imc;
        private readonly string[] classificacao = new string[]
        {
            "Abaixo do Peso",
            "Peso Ideal",
            "Sobrepeso",
            "Obesidade I",
            "Obesidade II",
            "Obesidade III"
        };


        private void ReceberDados()
        {
            try{
                Console.Write("Digite seu peso (Kg): ");
                peso = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Digite sua altura (m): ");
                altura = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida.");
                ReceberDados();
            }
        }      

        private void CalcularIMC()
        {
            imc = (peso / (altura * altura))*100;
            Console.WriteLine(imc);
            if (imc < 18.5)
            {
                Console.WriteLine($"Seu IMC é {imc:F2} - {classificacao[0]}"); //Abaixo do Peso
            }
            else if ((imc >= 18.5) && (imc < 25))
            {
                Console.WriteLine($"Seu IMC é {imc:F2} - {classificacao[1]}"); //Peso Ideal
            }
            else if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine($"Seu IMC é {imc:F2} - {classificacao[1]}"); //Sobrepeso

            }
            else if ((imc >= 30) && (imc < 35))
            {
                Console.WriteLine($"Seu IMC é {imc:F2} - {classificacao[2]}"); //Obesidade I
            }
            else if ((imc >= 35) && (imc < 40))
            {
                Console.WriteLine($"Seu IMC é {imc:F2} - {classificacao[3]}"); //Obesidade II
            }
            else
            {
                Console.WriteLine($"Seu IMC é {imc:F2} - {classificacao[4]}"); //Obesidade III
            }
        }
        public void Executar()
        {
            Console.WriteLine("Calculadora de IMC");
            ReceberDados();
            CalcularIMC();
        }
    }
}
