using System;


namespace dotNETLearning
{
    public class Sub
    {

        public void Substraction() {

            Console.WriteLine("Enter the First Number to Perfrom Substractions =");
            int FN = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter the Second Number to Perfrom Substractions = ");
            int SM = Convert.ToInt32(Console.ReadLine());

            int Sum;
            Sum = FN - SM;
            Console.WriteLine("The Substraction of two Numbers = {0}", Sum);
            Console.ReadLine();
        
        
        
        }
    }
}
