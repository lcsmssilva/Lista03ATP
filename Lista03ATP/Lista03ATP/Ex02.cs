using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex02
    {
        public static void Executar()
        {
            int n; //declarando variavel numeros
            int p = 0; //declarando variavel positivos
            int neg = 0; //declarando variavel negativos
            int z = 0; //declarando variavel zeros
            int i = 0;

            do
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

            double pp; //variavel de percentual positivo
            double pn; //variavel de percentual negativo
            double pz; //variavel de percentual zero

            pp = p * (p + neg + z); //atribuindo valor percentual positivo
            pn = neg * (p + neg + z); //atribuindo valor percentual negativo
            pz = z * (p + neg + z); //atribuindo valor percentual zero

            Console.WriteLine("Temos {0} numeros onde:\n {1}% são valores positivos \n {2}% são valores negativos e\n {3}% são iguais a zero.\n", i, pp, pn, pz);

        }
    }
}