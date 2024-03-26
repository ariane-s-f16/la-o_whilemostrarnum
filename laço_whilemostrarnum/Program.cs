using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laço_whilemostrarnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            while (cont >=1 && cont<101) 
            {
                Console.WriteLine(cont );
                cont++;
            }
            Console.ReadKey();
        }
    }
}
