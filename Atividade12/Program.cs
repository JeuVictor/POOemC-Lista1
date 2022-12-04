using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Ativ12 Media = new Ativ12();
            Console.WriteLine("12) Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas\r\npor um aluno nas 3 verificações e a média dos exercícios que fazem parte da\r\navaliação, e calcule a média de aproveitamento, usando a fórmula:\r\nMA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7\r\nA atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever\r\no número do aluno, suas notas, a média dos exercícios, a média de\r\naproveitamento, o conceito correspondente e a mensagem 'Aprovado' se o\r\nconceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.\r\nMédia de aproveitamento Conceito\r\n>= 90 A\r\n>= 75 e < 90 B\r\n>= 60 e < 75 C\r\n>= 40 e < 60 D\r\n< 40 E");
            Console.WriteLine("");
            Media.Dados();
            Media.MediaAluno();
            Media.Resultado();           

            Console.ReadKey();
            
        }
    }
}
