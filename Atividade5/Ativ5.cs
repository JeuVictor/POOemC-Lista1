using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5) Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo,
//imprimindo o resultado.
namespace Atividade5
{
    internal class Ativ5
    {
		private int valor;

		public int Valores
		{
			get { return valor; }
			set { valor = value; }
		}
		public void Resolucao()
		{
			if (Valores >= 0)
			{
				Console.WriteLine("O número é Positivo = "+ Valores*2);
			}
			else
			{
                Console.WriteLine("O número é Negativo = " + Valores*3);
            }

		}
		public void Questao()
		{
			Console.WriteLine("Questão - 5) Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso\r\nseja negativo, imprimindo o resultado.");
		}


	}
}
