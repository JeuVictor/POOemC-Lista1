using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ativ8 Ordem = new Ativ8();
            Ordem.Questão();
            Console.WriteLine("");
            Console.WriteLine("Digite o 1° valor: ");
            Ordem.A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor: ");
            Ordem.B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 3° valor: ");
            Ordem.C = Convert.ToInt32(Console.ReadLine());
            Ordem.Resolucao();
            Console.ReadKey();
        }
    }
}
