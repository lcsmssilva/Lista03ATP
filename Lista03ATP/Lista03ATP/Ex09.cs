using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03ATP
{
    public static class Ex09
    {
        public static void Executar()
        {
            double compra = 0; //declarando variavel compra
            double venda; //declarando variavel venda
            double l = 0; //declarando variavel lucro
            int ld = 0; //declarando variavel lucro menor que 10%
            int lv = 0; //declarando variavel lucro maior ou igual a dez e menor ou igual a 20
            int lmv =0; ///declarando variavel lucro maior que vinte
            double lt = 0; //declarando variavel lucro total
            double vtc = 0; //declarando variavel valor total compra
            double vtv = 0; //declarando variavel valor total de venda

            int f;

            do
            {
                Console.WriteLine("Insira o valor de compra :(Insira o valor 0 para encerrar)");
                compra = double.Parse(Console.ReadLine());


                Console.WriteLine("Insira o valor de venda: ");
                venda = double.Parse(Console.ReadLine());

                vtc = vtc + compra;
                vtv = vtv + venda;

                l = (compra / venda) * 100;
                lt = lt + l;

               if (l > 0 && l < 10)
                {
                    ld++;
                }
                else if (l >= 10 && l <= 20)
                {
                    lv++;
                }
                else if (l > 20)
                {
                    lmv++;
                }

                Console.WriteLine("Insira 0 se deseja finalizar ou 1 se quiser continuar.");
                f = int.Parse(Console.ReadLine());

            } while (f != 0);

            Console.WriteLine("O comercio teve {0}% de lucro total, sendo \n {1} mercadorias com o lucro abaixo de 10%, \n {2} mercadorias com o lucro de 10% até 20% \n {3} mercadorias com o lucro acima de 20%", lt, ld, lv, lmv);
            Console.WriteLine("O valor total de compra foi {0} e das vendas foram {1}.\n", vtc, vtv);
        }
    }
}
