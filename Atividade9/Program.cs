using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ativ9 ideal = new Ativ9();
            Console.WriteLine("Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um");
            Console.WriteLine("algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:\r\n● para homens: (72.7 * h) – 58;\r\n● para mulheres: (62.1 * h) – 44.7.");
            Console.WriteLine("");
            ideal.Dados();
            ideal.PesoIdeal();
            Console.ReadKey();
        }
    }
}
