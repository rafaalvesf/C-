//Rafael Ferreira Alves
//RA: 31725243
//Data: 25/11/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter escreva = new StreamWriter(@"C:\Users\Rafael\Desktop\EscEmArquivo-RafaelFalves\Exercicio2\Exercicio2.txt");

            int i = 1;
            while (i <= 100)
            {
                String frase = "Escrito no arquivo "+i;
                escreva.WriteLine(frase);
                i++;
            }
            escreva.Close();
            
        }
    }
}
