using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um
//algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
//● para homens: (72.7 * h) – 58;
//● para mulheres: (62.1 * h) – 44.7.
namespace Atividade9
{
    internal class Ativ9
    {
		private double Tamanho;

		public double Altura
		{
			get { return Tamanho; }
			set { Tamanho = value; }
		}
		private string Genero;

		public string Sexo
		{
			get { return Genero; }
			set { Genero = value; }
		}
        public double Peso;
        public void	Dados()
		{
			bool condição = true;
			Console.WriteLine("Digite a sua altura: ");
			this.Altura = Convert.ToDouble(Console.ReadLine());
			while (condição)
			{
				Console.WriteLine("Digite o seu Genero: [M/F] ");
				this.Genero = Console.ReadLine();
				this.Genero = Genero.ToUpper();
				
				if (this.Sexo == "M")
				{
					condição = false;
				}
				else if (this.Sexo == "F")
				{
					condição = false;
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Digite M para MASCULINO ou F para feminino: "); }
			}

		}

		public void PesoIdeal()
		{
			
			if (this.Sexo == "M")
			{
				Peso = (72.7 * this.Altura) - 58;
			}
			else
			{
				Peso = (62.1 * this.Altura) - 44.7;
			}
			Console.WriteLine("O peso peso ideal é "+this.Peso+"Kg.");
		}


	}
}
