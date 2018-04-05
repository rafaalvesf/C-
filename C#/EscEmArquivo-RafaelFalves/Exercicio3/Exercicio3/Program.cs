//Rafael Ferreira Alves
//Ra:31725243   
//Data: 25/11/2017


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter escreva = new StreamWriter(@"C:\Users\Rafael\Desktop\EscEmArquivo-RafaelFalves\Exercicio3\Exercicio3.txt");
            {
                Console.WriteLine("Digite o Nome do Usuário(a)");
                String Nome = Convert.ToString(Console.ReadLine());
                registra(Nome, escreva);
                

                Console.WriteLine("Digite o Sobrenome do Usuário");
                String Sobrenome = Convert.ToString(Console.ReadLine());
                registra(Sobrenome, escreva);

                Console.WriteLine("Digite a Idade do Usuário");
                string Idade = Convert.ToString(Console.ReadLine());
                registra(Idade, escreva);
            }
            escreva.Close();
            Console.WriteLine("Frase gravada");
            Console.ReadKey();
        }
        static void registra(string var,StreamWriter escreva)
        {
            char delimitador = ';';

            string[] substrings = var.Split(delimitador);
            foreach (var substring in substrings)
                escreva.Write(substring + delimitador);

        }
    }
}
