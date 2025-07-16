using System;

namespace DesafioCSharp
{
    class CalculadoraIMC
    {
         private double peso;
        private double altura;
        private double imc;
        private string classificacaoFinal;
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
            imc = peso / (altura * altura);
            Console.WriteLine(imc);
            if (imc < 18.5)
            {
                classificacaoFinal = classificacao[0]; //Abaixo do Peso
            }
            else if ((imc >= 18.5) && (imc < 25))
            {
                classificacaoFinal = classificacao[1]; //Peso Ideal
            }
            else if ((imc >= 25) && (imc < 30))
            {
                classificacaoFinal = classificacao[2]; //Sobrepeso

            }
            else if ((imc >= 30) && (imc < 35))
            {
                classificacaoFinal = classificacao[3]; //Obesidade I
            }
            else if ((imc >= 35) && (imc < 40))
            {
               classificacaoFinal = classificacao[4]; //Obesidade II
            }
            else
            {
               classificacaoFinal = classificacao[5]; //Obesidade III
            }
        }
        
        private void ExibirResultado(){
             Console.WriteLine($"Seu IMC é {imc:F2} - {classificacaoFinal}");
        }
        public void Executar()
        {
            Console.WriteLine("Calculadora de IMC");
            ReceberDados();
            CalcularIMC();
            ExibirResultado();
        }
    }
}
