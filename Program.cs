/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Aula do dia 15-03-2023
 */

//Algoritmo para se realizar somas, multiplicação, subtração, divisão e resto de divisão
// 3 - variáveis

double n1 = 0.00, n2 = 0.00; // quando se cria uma variável, ela é nula até que receba um valor.
double sum = 0.00;
double minus = 0.00;
double times = 0.00;
double divide = 0.00;
double rest = 0.00;

// 4 - entrada de dados
Console.WriteLine("Esse algoritmo faz operações aritméticas básicas ");
Console.WriteLine("Digite o primeiro valor");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
n2 = double.Parse(Console.ReadLine());

// 5 - processamento dos dados
sum = n1 + n2;
minus = n1 - n2;
times = n1 * n2;
divide = n1 / n2;
rest = n1 % n2;

// 6 - Saída
Console.WriteLine("O resultado da soma de " + n1 + " + " + n2 + " = " + sum);
Console.WriteLine("O resultado da subtração de " + n1 + " - " + n2 + " = " + minus);
Console.WriteLine("O resultado da multiplicação de " + n1 + " x " + n2 + " = " + times);
Console.WriteLine("O resultado da divisão de " + n1 + " ÷ " + n2 + " = " + divide + " e o resto da divisão é = " + rest);

// Estrutura de decisão - cálculos booleanos => if(){}else{}

n1 = 0.00; 
n2 = 0.00;
double operação = 0.00;
Console.WriteLine("Esse algoritmo faz operações aritméticas básicas ");
Console.WriteLine("Digite o primeiro valor");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
n2 = double.Parse(Console.ReadLine());




