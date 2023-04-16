using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex04
    {
        public static void Executar()
        {
            int n; //declarando variavel numero
            double e = 0; //declarando variavel E
            double fat = 1; //declarando fatorial
            double r = 0; //declarando resultado

            Console.WriteLine("Insira um valor inteiro e positivo: "); //atribuindo valor a n
            n = int.Parse(Console.ReadLine()); //convertendo n 'string' em n 'int'

            for (int i = 1; i <= n; i++) //executar comando enquanto i for menor ou igual a n
            {
                fat = fat * i; //fatorial é igual ele mesmo vezes i (atribuindo valor a fat)
                r = r + (1 / fat); //resultado é igual resultado mais resultado do parenteses de 1/fatorial (fat)
            }
            e = 1 + r; //atribuindo valor a e
            Console.WriteLine("{0} é o resultado de E.\n",e);
        }
    }
}
