using System;


namespace dotNETLearning
{
     class StringCon
    {

        public void TwoString()
        {
            Console.WriteLine("Enter the First Name = ");
            string _firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name = ");
            string _lastName = Console.ReadLine();

            Console.WriteLine("The Full Name of the User is " + _firstName + " " + _lastName);
            Console.ReadLine();


        }
    }
}
