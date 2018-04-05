using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wordlist
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 9999999;
            using (StreamWriter writer = new StreamWriter("C: \\Users\\rafael.ferreira\\Desktop\\wordlist.txt", true))
                            
            while(i<=10000000000)
            {
                    writer.WriteLine(i);
                Console.WriteLine(i);
                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}
