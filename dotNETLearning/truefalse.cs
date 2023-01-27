using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLearning
{
    class truefalse
    {

        public static void ReturnTF()
        {
            Console.WriteLine("Enter the Number Between 0 to 100");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0 && Number <= 100)
            {
                if (Number >= 40)
                {
                    Console.WriteLine("True");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("False");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid Number to Check the Result");
                Console.ReadLine();
            }
        }
    }
}
