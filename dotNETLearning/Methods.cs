using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLearning
{
    public class Methods
    {

        //Method Overloading Examples

        public static void AdditionofNumbers()
        {
            Console.WriteLine("This is an Example of Method Overloading");
            Console.ReadLine();

        }
        public static void AdditionofNumbers(int i, int j)
        {
            int sum = i + j;
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static void AdditionofNumbers(string str1, String str2)
        {
            Console.WriteLine("Your Full Name is = " + str1 + " " + str2);
            //Console.ReadLine();

        }

    }

        //Method Overriding with Example

        public class MethodsOverride
        {
            public virtual void Print()
            {
                Console.WriteLine("This is Base Class Message");
                //Console.ReadLine();
            }
        }

        public class MethodsOverride2 : MethodsOverride
        {
            public override void Print()
            {
                {
                    Console.WriteLine("This is Child Class Message");
                    //Console.ReadLine();
                }
            }

        }

        public class MethodsOverride3 : MethodsOverride2
        {
            public override void Print()
            {
                {
                    Console.WriteLine("This is Second Child Class Message");
                    Console.ReadLine();
                }
            }

        }
    }
