using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ativ7 At = new Ativ7();
            At.Questao();
            Console.WriteLine("");
            Console.WriteLine("Digite um número: ");
            At.Variaveis=Convert.ToInt32(Console.ReadLine());
            At.Resolucao();
            Console.ReadKey();
        }
    }
}
