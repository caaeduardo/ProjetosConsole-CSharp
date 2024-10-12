using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Lista4
    {
        internal void Exe1()
        {
            Console.WriteLine("1. Verificação de Número Par ou Ímpar: Escreva um programa que solicite um número ao usuário e verifique se ele é par ou ímpar.\n");
            {
                Console.Write("Digite um número: \n");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.\n");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.\n");
                }
            }
            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe2()
        {
            Console.WriteLine("2. Classificação de Idade: Peça ao usuário para inserir sua idade e classifique-o como Criança (0-12), Adolescente (13-17), Adulto(18-64), ou Idoso (65+).\n");
            {

            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe3()
        {
            Console.WriteLine("3. Verificação de Notas:\n");
            {
                Console.Write("Digite a nota (0 a 10): ");
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 6)
                {
                    Console.WriteLine("Aprovado");
                }
                else if (nota >= 4)
                {
                    Console.WriteLine("Recuperação");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe4()
        {
            Console.WriteLine("4. Cálculo de IMC:");
            {
                Console.Write("Digite seu peso (em kg): ");
                double peso = double.Parse(Console.ReadLine());
                Console.Write("Digite sua altura (em metros): ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    Console.WriteLine("Peso normal");
                }
                else if (imc >= 25 && imc < 30)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else
                {
                    Console.WriteLine("Obesidade");
                }
            }
            Console.WriteLine("Fim do exercício 4\n");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe5()
        {
            Console.WriteLine("5. Maior de Dois Números:");
            {
                Console.Write("Digite o primeiro número: \n");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: \n");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("O maior número é: " + num1);
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("O maior número é: " + num2);
                }
                else
                {
                    Console.WriteLine("Os números são iguais.\n");
                }
            }
            Console.WriteLine("Fim do exercício 5");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe6()
        {
            Console.WriteLine("6.Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.\n");
            {
                Console.Write("Digite sua idade: \n");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18 && idade <= 70)
                {
                    Console.WriteLine("Voto obrigatório.");
                }
                else if (idade >= 16 && idade < 18 || idade > 70)
                {
                    Console.WriteLine("Voto facultativo.");
                }
                else
                {
                    Console.WriteLine("Não pode votar.");
                }

            }
            Console.WriteLine("Fim do exercício 6");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe7()
        {
            Console.WriteLine("7.Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.\n");
            {
                Console.Write("Digite o valor da compra: R$ ");
                double valorCompra = double.Parse(Console.ReadLine());

                double valorFinal = valorCompra;

                if (valorCompra > 100)
                {
                    valorFinal = valorCompra * 0.9; // 10% no Vasco!
                }

                Console.WriteLine("Valor final: R$ " + valorFinal);



            }
            Console.WriteLine("Fim do exercício 7");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe8()
        {
            Console.WriteLine("8.Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.\n");
            {

                Console.Write("Digite a temperatura em Celsius: ");
                double temperatura = double.Parse(Console.ReadLine());

                if (temperatura < 15)
                {
                    Console.WriteLine("Frio");
                }
                else if (temperatura <= 25)
                {
                    Console.WriteLine("Agradável");
                }
                else
                {
                    Console.WriteLine("Quente");
                }

            }
            Console.WriteLine("Fim do exercício 8");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe9()
        {
            Console.WriteLine("9.Faça um algoritmo que leia 3 valores retorno do maior para o menor ordenados.\n");
            {

                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro número: ");
                double num3 = double.Parse(Console.ReadLine());

                double media = (num1 + num2 + num3) / 3;

                if (media > 7)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

            }
            Console.WriteLine("Fim do exercício 9");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe10()
        {
            Console.WriteLine("10.Faça um algoritmo que leia 3 valores retorne do menor para o maior ordenados.\n");
            {


                Console.Write("Digite um ano: ");
                int ano = int.Parse(Console.ReadLine());

                if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                {
                    Console.WriteLine("O ano é bissexto.");
                }
                else
                {
                    Console.WriteLine("O ano não é bissexto.");
                }

            }
            Console.WriteLine("Fim do exercício 10");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
