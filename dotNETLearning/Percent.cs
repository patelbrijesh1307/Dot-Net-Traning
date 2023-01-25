using System;


namespace dotNETLearning
{
    class Percent
    {
        public void TwoDec()
        {
            Console.WriteLine("Enter the First Decimal Number = ");
            double FN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second Decimal Number = ");
            double SN = Convert.ToDouble(Console.ReadLine());

            double PER;
            double Sum = FN + SN;
            PER = Sum * 100 / 200;
            Console.WriteLine("The Percentage of the Two Numbers is = {0}", PER);
            //Console.ReadLine();
            if(PER >= 85)
            {
                 Console.WriteLine("Topper");
            }
            else if (PER >= 70)
            {
                Console.WriteLine("Pass");
            }
            else if (PER >= 45)
            {
                Console.WriteLine("Pass");
            }
            else 
            {
                Console.WriteLine("You are Fail bro try Again");
            }
            Console.ReadLine();
        }
    }
}
