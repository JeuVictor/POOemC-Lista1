using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexteseTrainamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de\r\nA + B é menor que C.");
            Atividade1 A = new Atividade1();
            Console.WriteLine("Digite o 1° valor ");
            A.Valores = Convert.ToInt32(Console.ReadLine());
            Atividade1 B = new Atividade1();
            Console.WriteLine("Digite o 2° valor ");
            B.Valores = Convert.ToInt32(Console.ReadLine());
            Atividade1 C = new Atividade1();
            Console.WriteLine("Digite o 3° valor ");
            C.Valores = Convert.ToInt32(Console.ReadLine());
           
            if ((A.Valores + B.Valores) > C.Valores)
            {
                Console.WriteLine("O Valor " + A.Valores + " somado com " + B.Valores + " é maior que " + C.Valores);
            }
            else
            {
                Console.WriteLine("O Valor " + A.Valores + " somado com " + B.Valores + " é menor que " + C.Valores);
            }
            Console.ReadKey(); 
        }
        
    }

}
