using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    public static class CreateClass
    {
        public static void Func(decimal x)
        {
            Console.WriteLine( Decimal.ToInt64( x/2 ) );
        }
        static int Func(int x, int y)
        {
            return x + y;
        } 
    }
    public class CreateClass2
    {
        public void Func(decimal x)
        {
            Console.WriteLine(Decimal.ToInt64(x / 2));
        }
        public int Func(int x, int y)
        {
            return x + y;
        }
    }
}
