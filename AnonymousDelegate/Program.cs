using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate
{
    
    class Program
    {
        public delegate void DelegateSquare(int n);
        //delegate void DelegateSquare(int n);
        // no any method for the delegate
        DelegateSquare ds = delegate (int x)
        {
            Console.WriteLine(x * x);
        };
    
        static void Main(string[] args)
        {
            DelegateSquare ds = delegate (int x)
            {
                Console.WriteLine(x * x);
            };

            ds(4);
            Console.ReadKey();
        }

    }
}
