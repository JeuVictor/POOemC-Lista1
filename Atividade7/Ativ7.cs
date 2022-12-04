using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7) Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8,
//caso seja ímpar, imprimir o resultado desta operação.
namespace Atividade7
{
    internal class Ativ7
    {
        public void Questao()
        {
            Console.WriteLine("Questão - 7) Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8,\r\ncaso seja ímpar, imprimir o resultado desta operação.");
        }
        private int Variavel;

        public int Variaveis
        {
            get { return Variavel; }
            set { Variavel = value; }
        }
        public void Resolucao()
        {
            if (Variavel %2 == 0)
            {
                Console.WriteLine("O Valor é :" + (Variaveis + 5));
            }
            else
                {
                Console.WriteLine("O Valor é :" + (Variaveis + 8));
            }
        }
    }


}
