using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex01
    {
        public static void Executar()
        {
            int n; //declarando variavel numeros
            int p = 0; //declarando variavel positivos
            int neg = 0; //declarando variavel negativos
            int z = 0; //declarando variavel zeros
            int i = 0;

            do//declarando variavel i, repetindo 10x, i=i+1 
            {
                Console.Write("Digite o número desejado: ");
                n = int.Parse(Console.ReadLine()); //convertendo n 'string' em n 'int'

                if (n > 0) //se n maior que zero
                {
                    p++; //adiciona 1 a p (positivo)
                }
                else if (n < 0) //se n menor que zero
                {
                    neg++; //adiciona 1 a n (negativo)
                }
                else
                { //restante
                    z++; // adiciona 1 a zero
                }
                i++;
            } while (i < 10);
            Console.WriteLine("Foram digitados {0} números, onde \n temos {1} valores positivos \n {2} valores negativos \n {3} valores iguais a zero.\n", i, p, neg, z);

        }
    }
}
