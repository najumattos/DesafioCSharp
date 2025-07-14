# Desafios C#
Este repositório contém os três desafios do curso de C# Iniciante da Trilha Backend do Programa de Treinamento **FDevs**

## Como Usar
O programa principal oferece um menu de navegação que permite selecionar qual desafio executar. Para iniciar, basta compilar e rodar o projeto.

## Navegação
Ao executar o programa, o usuário será apresentado a um menu com as seguintes opções:

1: Desafio Soma dos Números

2: Desafio Cálculo de IMC

3: Desafio Calculadora Simples

- Digite o número correspondente ao desafio que deseja executar e pressione Enter.

## Desafios
### **Desafio Soma**

1. Soma dos Números de 1 a 10
Descrição:
Desenvolva um programa em C# que utilize uma estrutura de repetição for para calcular a soma dos números de 1 a 10. Exiba o resultado no console.

#### Implementação:

- Criação de um método privado para realizar a soma, utilizando um laço de repetição for para iterar os números e exibir o resultado.

- Chamada do método de soma dentro do método público Executar().

### **Desafio IMC**
2. Cálculo de Índice de Massa Corporal (IMC)
Descrição:
Crie um programa em C# que calcule o Índice de Massa Corporal (IMC). Solicite ao usuário que insira seu peso (em quilogramas) e sua altura (em metros). O IMC é calculado pela fórmula: IMC=peso/(altura∗altura). Exiba o resultado no console, indicando a faixa de classificação.

#### Implementação:

- Declaração de variáveis para peso, altura, IMC e um vetor para armazenar as classificações de peso.

- Criação de um método privado ReceberDados() para obter e validar os valores de peso e altura inseridos pelo usuário.

- Criação de um método privado CalcularIMC() para realizar o cálculo do IMC e determinar sua classificação.

- Chamada dos métodos ReceberDados() e CalcularIMC() dentro do método público Executar().

### **Calculadora Simples**
3. Calculadora Simples
Descrição:
Desenvolva uma calculadora simples em C# que permita ao usuário realizar operações de soma, subtração, multiplicação e divisão. O programa deve solicitar dois números e a operação desejada. Exiba o resultado no console.

#### Implementação:

- Declaração de variáveis para os dois números de entrada (numUm, numDois), o resultado (resultado) e a operação desejada.

- Criação de um método privado ReceberDados() para obter e validar os valores dos números e a operação desejada. Este método exibirá os números correspondentes para cada operação (servindo como valores para o switch case).

- Criação de um método privado Calcular() que utiliza uma estrutura switch case. Cada case corresponde a um número de operação, realiza o cálculo e exibe o resultado.

- Chamada dos métodos ReceberDados() e Calcular() dentro do método público Executar().

## Uso de IA
Não foi utilizada inteligência artificial para a resolução dos exercícios, mas foi empregada para a estruturação e organização deste README.
