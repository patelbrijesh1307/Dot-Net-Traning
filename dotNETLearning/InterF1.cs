using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLearning
{
    interface InterF1
    {
        void InterFacePrint();
    }
    class Customer1 : InterF1
    {
        public void InterFacePrint()
        {
            Console.WriteLine("This is an Interface Call");
            Console.ReadLine();
        }
    }
   
}
