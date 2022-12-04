using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atividade Pessoa = new Atividade();
            Pessoa.Mensagem();
            Console.WriteLine("");
            Console.WriteLine("Digite o nome da Pessoa: ");
            Pessoa.nome = Console.ReadLine();
            Console.WriteLine("Digite 'M' se a Pessoa for Masculino ou 'F' se for Feminina: ");
            Pessoa.Sexo = Console.ReadLine();
            Console.WriteLine("Digite o Estado civil da Pessoa:");
            Pessoa.EstatusCivil = Console.ReadLine();
            //Console.WriteLine(Pessoa.nome);
            //Console.WriteLine(Pessoa.Sexo);
            //Console.WriteLine(Pessoa.EstatusCivil);
            Pessoa.SeCasada();
            Console.ReadKey();
        }
    }
}
