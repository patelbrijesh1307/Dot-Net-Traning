using System;

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
