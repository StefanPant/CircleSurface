using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krug
{
    delegate double Surface(double r);

    class Program
    {
        static void Main(string[] args)
        {


            Surface Equals = (r) =>
            {
                return r * r * Math.PI;
                
            };

            Console.WriteLine("Result is: {0}", Equals(5));


            Console.ReadKey();
        }
    }



}
