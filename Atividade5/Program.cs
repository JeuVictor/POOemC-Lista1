using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ativ5 Resp = new Ativ5();
            Resp.Questao();
            Console.WriteLine("");
            Console.WriteLine("Digite um valor: ");
            Resp.Valores= Convert.ToInt32(Console.ReadLine());
            Resp.Resolucao();
            Console.ReadKey();
        }
    }
}
