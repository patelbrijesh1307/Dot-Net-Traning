using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLearning
{
    public class Add
    {
        public void Addition()
        {
            Console.WriteLine("Enter the First Number For Addition");
            int FN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number for Addition");
            int SN = Convert.ToInt32(Console.ReadLine());

            int Sum;
            Sum = FN + SN;
            Console.WriteLine("Total of Sum = {0} ", Sum);
            Console.ReadLine();
        }
    }
}
