using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3) Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
namespace Atividade3
{
	internal class Atividade3
	{
		private int ParImpar;

		public int ImparOuPAr
		{
			get { return ParImpar; }
			set { ParImpar = value; }
		}
		public void Resultado()
		{ if (this.ParImpar % 2 == 0)
			{
				Console.WriteLine("O número "+this.ParImpar+" é par.");
			}
		else
			{
                Console.WriteLine("O número " + this.ParImpar + " é impar.");
            }
				}
		public void Questao()
		{
			Console.WriteLine("Atividade - 3) Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.");
		}
	}
}
