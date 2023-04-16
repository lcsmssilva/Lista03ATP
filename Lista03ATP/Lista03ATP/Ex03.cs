using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex03
    {
        public static void Executar()
        {
            int n; //declarando variavel numero
            int du = 0; //declarando variavel dividido por 3 e 9 (divisão um)
            int dd = 0; //declarando variavel dividido por 2 (divisão dois)
            int dt = 0; //declarando variavel dividido por 5 (divisão três)
            int nd = 0; //declarando variavel não divisivel por 3,9,2 ou 5
            int i = 0; //declarando variavel 

            do //faça o comando
            {
                Console.Write("Insira os números: "); //atribuindo valor a variavel n
                n = int.Parse(Console.ReadLine()); //convertendo n 'string' em n 'int'
                if (n != 0 && n % 3 == 0 && n % 9 == 0) //verificando se é divisivel por 3 e 9
                {
                    du++;
                }
                if (n != 0 && n % 2 == 0) //verificando se é divisivel por 2
                {
                    dd++;
                }
                if (n != 0 && n % 5 == 0) //verificando se é divisivel por 5
                {
                    dt++;
                }
                if (n == 0 || n % 3 != 0 && n % 9 != 0 && n % 5 !=0 && n % 2 !=0) //verificando se não é divisivel por 3, 9, 2 ou 5
                {
                    nd++;
                }
                i++;
            } while (i < 10); //enquanto i for menor que 10
            Console.WriteLine("Dentre os números temos: {0} divisiveis por 3 e 9\n{1} divisiveis por 2 \n{2} divisiveis por 5 e\n{3} não são divisiveis por 3, 9, 2 ou 5.\n", du, dd, dt, nd);
        }
    }
}
