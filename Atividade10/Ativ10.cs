using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade10
{
    internal class Ativ10
    {
		private double Peso;

		public double Massa
		{
			get { return Peso; }
			set { Peso = value; }
		}
		private double Tamanho;

		public double Altura
		{
			get { return Tamanho; }
			set { Tamanho = value; }
		}
		public double IMC;
		public string Resultado;

		public void Dados()
		{
            Console.WriteLine("Digite a sua altura: ");
            this.Tamanho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a seu peso: ");
            this.Peso = Convert.ToDouble(Console.ReadLine());
        }
		public void TabelaIMC()
		{
			IMC = Massa/ (Altura*Altura);
			IMC = Math.Round(IMC, 2);
			if (IMC > 0 && IMC < 18.5)
                { Resultado = "abaixo do peso"; }
			else if (IMC >= 18.5 && IMC	< 25)
            { Resultado = "peso normal"; }
            else if (IMC >= 25 && IMC < 30)
            { Resultado = "acima do peso"; }
            else if (IMC >= 30)
            { Resultado = "obeso"; }
			else
			{ Console.WriteLine("Valor digitado errado: Erro no Peso e/ou Altura");	}
            if (IMC > 0)
			{ Console.WriteLine("Seu IMC é " + IMC + " e está " + Resultado + "."); }
        }

	}
}
/*10) O IMC – Índice de Massa Corporal é um critério da Organização Mundial de
Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.
A fórmula é: IMC = peso / (altura)2
Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua
condição de acordo com a tabela abaixo.
IMC em adultos Condição
Abaixo de 18,5 Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30 Acima do peso
 Acima de 30 obeso*/

