using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ativ10 imc = new Ativ10();
            Console.WriteLine("10) O IMC – Índice de Massa Corporal é um critério da Organização Mundial de\r\nSaúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.\r\nA fórmula é: IMC = peso / (altura)2\r\nElabore um algoritmo que leia o peso e a altura de um adulto e mostre sua\r\ncondição de acordo com a tabela abaixo.\r\nIMC em adultos Condição\r\nAbaixo de 18,5 Abaixo do peso\r\nEntre 18,5 e 25 Peso normal\r\nEntre 25 e 30 Acima do peso\r\n Acima de 30 obeso ");
            Console.WriteLine("");
            imc.Dados();
            imc.TabelaIMC();
            Console.ReadLine();
        }
    }
}
