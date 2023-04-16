using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex05
    {
        public static void Executar()
        {
            double sal = 0, medSal = 0, maiorS = 0, numF = 0, medF = 0, h = 0, ppac = 0; /*declarando variavel salario (sal)
                                                                                          * media salarial (medSal)
                                                                                          * maior Salario (maiorS)
                                                                                          * numero de filhos (numF)
                                                                                          * media de filhos (medF)
                                                                                          * habitantes (h)
                                                                                          * percentual de pessoas com salario até R$100,00 */
            int i = 1;
            do
            {

                Console.WriteLine("Insira a quantidade de filhos: "); //atribuindo valor a numF
                numF = double.Parse(Console.ReadLine()); //convertendo sal 'string' em sal 'double'

                h++;

                Console.WriteLine("Insira o valor do salário: "); //atribuindo valor a sal
                sal = double.Parse(Console.ReadLine()); //convertendo sal 'string' em sal 'double'

                medSal += sal; //medSal = medSal + sal


                if (sal > maiorS) //se salario (sal) maior que o maior salario até o momento, substitui
                {
                    maiorS = sal;
                }
                if (sal <= 100) //se salario menor ou igual a 10
                {
                    ppac++;
                }
                medF += numF;

                Console.WriteLine("Insira 0 para finalizar ou outro número para continuar: ");
                i = int.Parse(Console.ReadLine());

            } while (i != 0); //enquanto numero de filhos for maior ou igual a 0 e salario for maior que zero

            medSal = (medSal / h);
            medF = medF / h;

            ppac = (ppac/h) * 100; //atribuindo valor percentual de pessoas com salario ate R100,00
            Console.WriteLine("{0} é a média salarial.", medSal);
            Console.WriteLine("{0} é o maior salário.", maiorS);
            Console.WriteLine("{0}% é o percentual de pessoas que recebem R$100,00 ou menos.", ppac);
            Console.WriteLine("{0} é a média de filhos por habitante.\n", medF);

        }
    }
}
