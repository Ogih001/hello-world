using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EleLoop(3, "me"));
        }
        public static string EleLoop(int n, string arr1)
        {
            return arr1 + EleLoop(n - 1, arr1);
        }
    }
}
