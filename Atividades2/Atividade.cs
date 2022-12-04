using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades2
{
    internal class Atividade
    {
		private string Nome;

		public string nome
		{
			get { return Nome; }
			set { Nome = value.ToUpper(); }
		}
		private string Genero;

		public string Sexo
		{
			get { return Genero; }
			set { Genero = value.ToUpper(); }
		}
		private string EstadoCivil;

		public string EstatusCivil
		{
			get { return EstadoCivil; }
			set { EstadoCivil = value.ToUpper(); }
		}
		public void Mensagem()
		{
			Console.WriteLine("Atividade - 2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. \r\nCaso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).");

        }
		public void SeCasada()
		{
			if ((this.EstadoCivil == "CASADA") && this.Sexo == "F")
			{
				int TempoCasada = 0;
				Console.WriteLine("Digite o ano do casamento: ");
				TempoCasada = Convert.ToInt32(Console.ReadLine());
				DateTime hoje = DateTime.Now;
				int ano = hoje.Year;
				int idade = ano - TempoCasada;
				Console.WriteLine(" Tem "+idade+" anos de casada");
			}
		}
	}
}
