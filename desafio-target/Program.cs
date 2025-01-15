using System;

namespace desafio_target
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 1:");
            Desafio1();
            Console.WriteLine();

            Console.WriteLine("Desafio 2:");
            Desafio2();
            Console.WriteLine();

            Console.WriteLine("Desafio 3:");
            Desafio3();
            Console.WriteLine();

            Console.WriteLine("Desafio 4:");
            Desafio4();
            Console.WriteLine();

            Console.WriteLine("Desafio 5:");
            Desafio5();
            Console.WriteLine();

            Console.ReadKey();
        }

        // desafio 1
        static void Desafio1()
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k++;
                soma = soma + k;
            }

            Console.WriteLine(soma);            
        }

        // desafio 2
        static void Desafio2()
        {
            Console.Write("Digite um número a seguir: ");

            int numero = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            int proximo;

            while (b < numero)
            {
                proximo = a + b;
                a = b;
                b = proximo;
            }

            if (b == numero || numero == 0)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonaci.");
            }
            else
            {
                Console.WriteLine($"O numero {numero} não pertence à sequência de Fibonacci.");
            }
        }

        // desafio 3
        static void Desafio3()
        {
        }

        // desafio 4
        static void Desafio4()
        {
        }

        // desafio 5
        static void Desafio5()
        {
        }
    }
}
