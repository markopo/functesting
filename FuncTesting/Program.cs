using System;

namespace FuncTesting
{
    public static class ArgsExtension {
        public static Func<T2, T1, R> SwapArgs<T1, T2, R>(this Func<T1, T2, R> f) 
                    => (t2, t1) => f(t1, t2); 
    }
    
    class Program
    {

        static void Main(string[] args)
        {
               Func<int, int, int> divide = (t1, t2) => t1 / t2; 
               
               var r1 = divide(21, 3);
               
               Console.WriteLine(r1); 
               
               var divide2 = divide.SwapArgs();

               var r2 = divide2(2, 10);
               
               Console.WriteLine(r2);


        }
    }
}