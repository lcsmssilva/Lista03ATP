using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex08
    {
        public static void Executar()
        {
            int L; // declarando a variavel que o usuario vai digitar
            Console.Write("Insira o valor desejado de números da série de fibonnaci: "); //atribuindo valor a variavel L
            L = int.Parse(Console.ReadLine()); //convertendo L 'string' em L 'int'

            int f = 0; //declarando variavel fibonacci
            int aux = 1; //declarando variavel auxiliar
            int b = 0; //declarando variavel b


            for (int i = L - 1; i > 0; i--) //enquanto i for menor que L, executar repetição
            {
                f = aux + b; // f (fibonacci) é igual a auxiliar mais b
                Console.WriteLine("{0}", f); //mandando computador escrever na linha

                aux = b; //auxiliar receberá o valor de b
                b = f; //b receberá o valor de f (fibonacci)
            }
        }
    }
}
