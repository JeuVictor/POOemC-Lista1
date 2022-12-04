using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3) Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atividade3 Valor = new Atividade3();
            Valor.Questao();
            Console.WriteLine("");
            Console.WriteLine("Digite um número: ");
            Valor.ImparOuPAr = Convert.ToInt32(Console.ReadLine());
            Valor.Resultado();
            Console.ReadKey();
        }
    }
}
