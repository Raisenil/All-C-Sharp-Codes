using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            //name,id,balance,monthly transaction
            Savings s = new Savings("NIloy", 19399821, 10000,3);
            s.Showinfo();
            s.withdrawing(700);
            Console.WriteLine();

            //name,id,balance,creat year,tenure
            Fixed f=new Fixed("Raisul",19399821,10000,2015,5);
            f.Showinfo();
            f.withdrawing(300);
            Console.WriteLine();

            //Not mature
            Fixed f1=new Fixed("Tonoy",9821,10000,2015,7);
            f1.Showinfo();
            f1.withdrawing(3000);
            Console.WriteLine();

            SpecialSavings s1 = new SpecialSavings("NIloy", 19399821, 10000,3);
            s1.Showinfo();
            s1.withdrawing(2000);
            Console.WriteLine();

            ///will not withdraw
            SpecialSavings s2 = new SpecialSavings("NIloy", 19399821, 10000,3);
            s2.Showinfo();
            s2.withdrawing(2000);
            Console.WriteLine();

            OverDraft o = new OverDraft("NIloy", 19399821, 10000,3);
            o.Showinfo();
            o.withdrawing(200);
            Console.WriteLine();
        }
    }
}