using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    internal class Ativ12
	{
		private string Id;
		public string IdAlunos
		{
			get { return Id; }
			set { Id = value; }
		}
		public double[] notas = new double[3];
		public double MediaAritmetica;
		public double MediaNota;
		public string situacao;
		public string AprovReprov;
        public void Dados()
		{
			Console.WriteLine("Digite o Codigo de Identificação do Aluno: ");
			Id = Console.ReadLine();
			for (int i = 0; i < notas.Length; i++)
			{
				Console.WriteLine("Digite a " + (i + 1) + "° nota: ");
				notas[i] =Convert.ToDouble(Console.ReadLine());
				MediaAritmetica += notas[i];
			}
		}
		public void MediaAluno()
		{
			MediaAritmetica = (MediaAritmetica / 3);
			MediaNota = (notas[0]+ (notas[1]*2) + (notas[2]*3) + MediaAritmetica )/ 7;
			MediaNota = Math.Round(MediaNota, 2);
        }
		public void Resultado()
		{
			if (MediaNota >= 0 && MediaNota < 40)
			{ situacao = "E"; AprovReprov = "Reprovado"; }
            else if (MediaNota >= 40 && MediaNota < 60)
            { situacao = "D"; AprovReprov = "Reprovado"; }
            else if (MediaNota >= 60 && MediaNota < 75)
            { situacao = "C"; AprovReprov = "Aprovado"; }
            else if (MediaNota >= 75 && MediaNota < 90)
            { situacao = "B"; AprovReprov = "Aprovado"; }
            else if (MediaNota >= 90 && MediaNota < 100)
            { situacao = "A"; AprovReprov = "Aprovado"; }
			Console.WriteLine("O aluno de ID '"+IdAlunos+"' foi "+AprovReprov+" com a Media de aproveitamento de "+ MediaNota+" e o conceito ficou de "+situacao+".");
        }
    }
}
/*12) Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas
por um aluno nas 3 verificações e a média dos exercícios que fazem parte da
avaliação, e calcule a média de aproveitamento, usando a fórmula:
MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7
A atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever
o número do aluno, suas notas, a média dos exercícios, a média de
aproveitamento, o conceito correspondente e a mensagem 'Aprovado' se o
conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.
Média de aproveitamento Conceito
>= 90 A
>= 75 e < 90 B
>= 60 e < 75 C
>= 40 e < 60 D
< 40 E
 */