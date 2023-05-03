using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1, P2;

            Console.Write("Digite a 1° nota: ");
            P1 = double.Parse(Console.ReadLine());

            P2 = ((5 * 3) - P1) / 2;

            Console.WriteLine("O aluno tem que tirar {0} na 2° prova para passar", P2);
        }
    }
}
