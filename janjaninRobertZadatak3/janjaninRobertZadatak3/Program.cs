using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janjaninRobertZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos;
            Console.WriteLine("upisi rijec: ");
            unos=Console.ReadLine();
            for (int i = unos.Length - 1; i > 0; i--)
            {

                Console.WriteLine(unos.Substring(i,1));

            }
            

            Console.ReadKey();
        }
    }
}
