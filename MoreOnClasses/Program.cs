using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateClass2 createClass2 = new CreateClass2();
            Console.WriteLine("Enter a number");
            decimal num = Convert.ToDecimal( Console.ReadLine() );
            int newNum = (int)num;
            createClass2.Func( newNum, newNum + 1 );

            CreateClass.Func(num);
            
        }
    }
}
