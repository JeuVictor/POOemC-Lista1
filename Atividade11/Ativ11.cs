using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    internal class Ativ11
    {
		private int Cod;

		public int Codigo
		{
			get { return Cod; }
			set { Cod = value; }
		}
		private double Valor;
		public double Preco
		{
			get { return Valor; }
			set { Valor = value; }
		}
		public double desconto;
		public double ValorPagar;
        public bool condicao = true;
		public string pag;
		public void Dados()
		{
			Console.WriteLine("Digite o Valor do produto: ");
            Valor = Convert.ToDouble(Console.ReadLine());
			while (condicao)
			{
				Console.WriteLine("Digite o Codigo para a compra? ");
				Cod = Convert.ToInt32(Console.ReadLine());
				if (Cod >0 && Cod < 5)
				{ condicao = false; }
				else
				{ Console.WriteLine("Codigo digitado invalido"); }
			}
		}

		public void Pagamento()
		{
			if (Cod == 1)
			{ desconto = 0.9; pag = "pago a vista em dinheiro ou cheque com 10% de desconto"; }
			else if (Cod == 2)
			{ desconto = 0.85; pag = "pago a vista  no cartão de crédito com 15% de desconto"; }
			else if (Cod == 3)
				{ desconto = 1; pag = "parcelado em até 2 vezes e sem desconto"; }
			else
				{ desconto = 1.1; pag = "parcelado em mais de 2 vezes com a taxa de 10% de juros"; }
			ValorPagar = Valor * desconto;
			Console.WriteLine("O Valor foi "+ pag+" e o total a pagar é de R$"+ValorPagar);
		}
	}
}
/*
 11) Elabore um algoritmo que calcule o que deve ser pago por um produto,
considerando o preço normal de etiqueta e a escolha da condição de pagamento.

Utilize os códigos da tabela a seguir para ler qual a condição de pagamento
escolhida e efetuar o cálculo adequado.
Código Condição de pagamento
1 À vista em dinheiro ou cheque, recebe 10% de desconto
2 À vista no cartão de crédito, recebe 15% de desconto
3 Em duas vezes, preço normal de etiqueta sem juros
4 Em duas vezes, preço normal de etiqueta mais juros de 10%
 */
