using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLearning
{
    class Program 
    {
        int FirstNumber;
        int SecondNumber;

        static void Main(string[] args)
        {
            // InterFace with Inheritance Example
            //InterF1 I1 = new Customer1();
            //I1.InterFacePrint();

            //Addition of Two Numbers with Methods
            //Add add = new Add();
            //add.Addition();

            //Substraction of Two Numbers with Methods
            //Sub sub = new Sub();
            //sub.Substraction();

            //Averrage of Two Numbers With Methods
            //Ave ave = new Ave();
            //ave.Average();

            // Addign Two String With Each Other
            //StringCon stringCon = new StringCon();
            //stringCon.TwoString();

            //Find Percentage of Two Decimal Number with Method
            //Percent percent = new Percent();
            //percent.TwoDec();

            

        }
        // Constructor with taking arguments on it
        //Program P = new Program();
        //Program P = new Program(12, 12);


        public Program()
        {
        }

        public Program(int FN, int SN)
        {
            this.FirstNumber = FN;
            this.SecondNumber = SN;
        }

        
    }

    public static class StaticClass
    {

    }
}
