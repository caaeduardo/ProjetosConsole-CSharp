using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Lista3
    {
        internal void Exe1()
        {
            Console.WriteLine("1.Faça um programa que receba 3 valores e retorne a soma deles.\n");
            {
                Console.WriteLine("Digite o primeiro valor:\n");
                int valor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor:\n");
                int valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o terceiro valor: \n");
                int valor3 = int.Parse(Console.ReadLine());

                int
                 soma = valor1 + valor2 + valor3;

                Console.WriteLine("A soma dos valores é: " + soma);
            }
            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe2()
        {
            Console.WriteLine("2.Faça um programa que receba quatro notas e retorne a média.\n");
            {
                Console.WriteLine("Digite a primeira nota:\n");
                double nota1 = double.Parse(Console.ReadLine());
                double nota2 = double.Parse(Console.ReadLine());
                double nota3 = double.Parse(Console.ReadLine());
                double nota4 = double.Parse(Console.ReadLine());
                
                double media = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("A média é: " + media);
            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe3()
        {
            Console.WriteLine("3.Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome\n");
            {
                string nome;

                do
                {
                    Console.WriteLine("Digite um nome (para sair digite 'João'):");
                    nome = Console.ReadLine();
                } 
                while (nome != "João");
            }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe4()
        {
            Console.WriteLine("4.Faça um programa que retorne à quantidade de números pares existente entre 35 e 98111");
            {
                int contadorPares = 0;

                for (int i = 35; i <= 98111; i++)
                {
                    if (i % 2 == 0)
                    {
                        contadorPares++;
                    }
                }

                Console.WriteLine("A quantidade de números pares entre 35 e 98111 é: " + contadorPares);
            }
            Console.WriteLine("Fim do exercício 4\n");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe5()
        {
            Console.WriteLine("5.FaÇa um programa que some todos os números ímpares de 1 até 5000\n");
            {
                int somaImpares = 0;

                for (int i = 1; i <= 5000; i += 2)
                {
                    somaImpares += i;
                }

                Console.WriteLine("A soma dos números ímpares de 1 a 5000 é: " + somaImpares);
            }
            Console.WriteLine("Fim do exercício 5");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe6()
        {
            Console.WriteLine("6.Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.\n");
            {
                Console.WriteLine("Digite um número para calcular a tabuada:\n");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine(numero + " x " + i + " = " + resultado);
                }
                Console.WriteLine("Fim do exercício 6");
                Console.WriteLine("-------------------------------------------------------------");
            }      
            
        }
    }
}
