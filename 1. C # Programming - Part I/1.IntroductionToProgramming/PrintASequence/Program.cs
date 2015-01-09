using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=2; i<=12 ; i++)
            {
                int n = i;
                if (n % 2 != 0)
                    n = -n;
                Console.Write(n + " ");
            }
        }
    }
}
