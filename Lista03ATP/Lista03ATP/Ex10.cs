using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex10
    {
        public static void Executar()
        {
            int cu = 0; //declarando variaveis candidato 1
            int cd = 0; //declarando variaveis candidato 2
            int ct = 0; //declarando variaveis candidato 3
            int cq = 0; //declarando variaveis candidato 4
            int vn = 0; //declarando variaveis votos nulos
            int vb = 0; //declarando variaveis votos em branco
            int v = 1; //declarando variavel votos
            int codigo;

            do
            {
                Console.WriteLine("Insira o código de seu candidato");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    cu++;
                } else if (codigo == 2)
                {
                    cd++;
                } else if (codigo == 3)
                {
                    ct++;
                } else if (codigo == 4)
                {
                    cq++;
                } else if (codigo == 5)
                {
                    vn++;
                } else if (codigo == 6)
                {
                    vb++;
                }
                Console.WriteLine("Insira 0 para finalizar ou outro numero para prosseguir.");
                v = int.Parse(Console.ReadLine());

            } while (v != 0);
            Console.WriteLine("O candidato um recebeu {0} votos.\nO candidato dois recebeu {1} votos.\nO candidato três recebeu {2} votos.\nO candidato quatro recebeu {3} votos.\nTiveram {4} votos nulos e {5} votos em branco", cu, cd, ct, cq, vn, vb);
        }
    }
}
