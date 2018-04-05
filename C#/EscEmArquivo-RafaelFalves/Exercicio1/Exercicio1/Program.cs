//Rafael Ferreira Alves
//RA: 31725243  
//Data: 25/11/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            String Escreva = "Primeira Escrita em arquivos";
            StreamWriter text = new StreamWriter(@"C:\Users\Rafael\Desktop\EscEmArquivo-RafaelFalves\Exercicio1\Exercicio1.txt");
            text.WriteLine(Escreva);
            text.Close();
            
            
            {

            }
        }
    }
}
