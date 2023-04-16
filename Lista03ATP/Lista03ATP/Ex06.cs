using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex06
    {
        public static void Executar()
        {
            int n; // declarando a variavel 
            Console.WriteLine("Insira um valor inteiro e positivo: "); //atribuindo valor a variavel
            n = int.Parse(Console.ReadLine()); //convertendo n 'string' em n 'int'

            double s = 1; //declarando variavel resultado final
            double t = 0; //declarando variavel resultado da divisão
            double b = 2; //declarando variavel divisor

            for (int i = 1; i <= n; i++) // enquanto i for menor ou igual a variavel n, continua executando  o for (repetição)
            {
                t = t + (1 / b); //comando para achar o resultado das divisões
                b++;
                Console.WriteLine("O termo gerado no {0}° comando foi {1}", i, t);
            }
            s = s + t; //atribuindo valor a variavel s
            Console.WriteLine("O resultado final é: {0:f2}\n", s);
        }
    }
}
