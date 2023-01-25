using System;


namespace dotNETLearning
{
    public class Ave
    {
        public void Average()
        {
            Console.WriteLine("Enter the First Number to find the Average of Two Numbers");
            int FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number to find the Average of Two Numbers");
            int SN = Convert.ToInt32(Console.ReadLine());

            float Total;
            Total = (FN + SN) / 2;
            Console.WriteLine("The Average of Two Numbers is = {0}", Total);
            Console.ReadLine();
        }
    }
}
