using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengamatan4
{
    //deklarasi delegate
    public delegate double Delegate_Prod(int a, int b);
    class Program
    {
        //function for implementation delegate
        static double fn_Prodvalues(int val1, int val2)
        {
            return val1 * val2;
        }
        static void Main(string[] args)
        {
            //inherit delegete and initialization with function fn_Prodvalues
            Delegate_Prod delObj = new Delegate_Prod(fn_Prodvalues);
            Console.Write("Please Enter Values :");
            int v1 = Int32.Parse(Console.ReadLine());
            int v2 = Int32.Parse(Console.ReadLine());

            //initiali object delObj for output
            double res = delObj(v1, v2);
            Console.WriteLine("Result :{0}", res);
            Console.ReadLine();
        }
    }
}
