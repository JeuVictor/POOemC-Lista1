using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6) Escreva um algoritmo que lê dois valores booleanos (lógicos) e então
// determina se ambos são VERDADEIROS ou FALSOS.
namespace Atividade6
{
    internal class Ativ6
    {
       public bool X, Y;
        
        public void Questao()
        {
            Console.WriteLine("Questão - 6) Escreva um algoritmo que lê dois valores booleanos (lógicos) e então\r\ndetermina se ambos são VERDADEIROS ou FALSOS.");
        }
        public void Boleano()
        {
            if ((Y == true)&& (X == true))
            {
                Console.WriteLine(" O Valor é verdadeiro");
            }
            else
            {
                Console.WriteLine(" O Valor é falso");
            }
        }

    }
}
