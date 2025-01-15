using System;
using System.Collections.Generic;
using System.Linq;

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
            var faturamento = new List<double> { 221.5, 0, 345.7, 0, 150.3 };
            var valores = faturamento.Where(x => x > 0).ToList();
            double menor = valores.Min();
            double maior = valores.Max();
            double media = valores.Average();
            int diasAcimaDaMedia = valores.Count(v => v > media);


            Console.WriteLine($"Menor valor ocorrido: {menor}");

            Console.WriteLine($"Maior valor ocorido: {maior}");

            Console.WriteLine($"Número de dias do mês acima  da média mensal: {diasAcimaDaMedia}");
        }

        // desafio 4
        static void Desafio4()
        {            
            double faturamentoSP = 67836.43;
            double faturamentoRJ = 36678.66;
            double faturamentoMG = 29229.88;
            double faturamentoES = 27165.48;
            double faturamentoOutros =  19849.53;
           
            double total = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            Console.WriteLine($"SP: {((faturamentoSP / total) * 100):F2}%");
            Console.WriteLine($"RJ: {((faturamentoRJ / total) * 100):F2}%");
            Console.WriteLine($"MG: {((faturamentoMG / total) * 100):F2}%");
            Console.WriteLine($"ES: {((faturamentoES / total) * 100):F2}%");
            Console.WriteLine($"Outros: {((faturamentoOutros / total ) * 100):F2}%");
        }

            // desafio 5
        static void Desafio5()
        {
            Console.Write(" Digite uma string:  ");

            string stringDigitada = Console.ReadLine();

            string stringInvertida = "";


            for (int i = stringDigitada.Length - 1; i >= 0; i--)
            {
                stringInvertida += stringDigitada[i];
            }

            Console.WriteLine( $"String invertda : {stringInvertida}");
        }
    }
}
