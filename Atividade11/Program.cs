using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ativ11 Compra = new Ativ11();
            Console.WriteLine("11) Elabore um algoritmo que calcule o que deve ser pago por um produto,\r\nconsiderando o preço normal de etiqueta e a escolha da condição de pagamento.\r\n\r\nUtilize os códigos da tabela a seguir para ler qual a condição de pagamento\r\nescolhida e efetuar o cálculo adequado.\r\nCódigo Condição de pagamento\r\n1 À vista em dinheiro ou cheque, recebe 10% de desconto\r\n2 À vista no cartão de crédito, recebe 15% de desconto\r\n3 Em duas vezes, preço normal de etiqueta sem juros\r\n4 Em duas vezes, preço normal de etiqueta mais juros de 10%");
            Console.WriteLine("");
            Compra.Dados();
            Compra.Pagamento();
            Console.ReadKey();
        }
    }
}
