using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class Program
    {
        public delegate int refmethod(int a, int b);
        
        static void Main(string[] args)
        {
            int result;
            refmethod add = delegate (int i, int j)
            {
                return i + j;
            };
           result=add(1, 2);
            Console.WriteLine(result);
            
        }
    }
}
