using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8) Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os
//em ordem decrescente.
namespace Atividade8
{
    internal class Ativ8
    {
        public void Questão()
        {
            Console.WriteLine("Questão - 8) Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os\r\nem ordem decrescente.");
        }
        public int A, B, C, D;
        public void Resolucao()
        {
            if ((A >= B) && (A >= C))
            {
                D = A;
                if (B >= C)
                { A = B; B = C; }
                else
                {
                    A = C;
                }
            }
            else if ((B >= A) && (B >= C))
            {
                D = B; B = A;
                if (A > C)
                { B = C; }
                else
                { A = C; B = A; }
            }
            else if ((C >= A) && (C >= B))
            {
                D = C;
                if (A >= B)
                { A = A; }
                else
                { C = A; A = B; B = C; }
            }
            Console.WriteLine("A ordem certa é :"+ D +", "+ A+ ", " + B + ".");
        }
    }

}
