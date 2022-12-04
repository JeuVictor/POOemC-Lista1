using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Ativ4 ValorA=new Ativ4();
            ValorA.Questao();
            Console.WriteLine("");
            Console.WriteLine("Digete o 1° Valor: ");
            ValorA.Valores = Convert.ToInt32((Console.ReadLine()));
            Ativ4 ValorB = new Ativ4();
            Console.WriteLine("Digete o 2° Valor: ");
            ValorB.Valores = Convert.ToInt32((Console.ReadLine()));
            Ativ4 ValorC = new Ativ4();
           
            if (ValorA.Valores == ValorB.Valores)
            {
                ValorC.Valores = ValorA.Valores + ValorB.Valores;
            }
            else
            {
                ValorC.Valores = ValorA.Valores * ValorB.Valores;
            }
            Console.WriteLine("O 3° Valor é "+ ValorC.Valores);
            
            Console.ReadKey();
        }
    }
}
