//Rafael Ferreira Alves
//RA 31725243   
//Data 26/11/2017
//Programa :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta a = new Conta();
            Console.WriteLine("Digite o numero da conta");
            a.numeroconta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da agencia");
            a.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo da conta");
            a.saldo = double.Parse(Console.ReadLine());
        }
    }
}
