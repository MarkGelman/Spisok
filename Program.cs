using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamena_simvolov_odin_na_odin
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            int N = int.Parse(Console.ReadLine());
            string str1 = Console.ReadLine();
            Console.Write(str1.Substring(0, 1).ToUpper() + str1.Substring(1));
            if (j < N)
                do
                {
                    str1 = Console.ReadLine();
                    Console.WriteLine(", " + str1);
                    str1 = Console.ReadLine() + ".";
                    j++;
                }
                while (j < N);
            Console.WriteLine(".");
        }
    }
}
