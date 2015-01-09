using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=2; i<=1002 ; i++)
            {
                int n = i;
                if (n % 2 != 0)
                    n = -n;
                Console.Write(n + " ");
            }
        }
    }
}