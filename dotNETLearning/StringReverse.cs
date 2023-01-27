using System;

namespace dotNETLearning
{
    class StringReverse
    {
        
        public void strReverse()
        {
        StringReve:
            Console.WriteLine("Enter a String with Min 3 Char and Maximum 10");
            string strMessage = Console.ReadLine();

            if (strMessage.Length >= 3 && strMessage.Length <= 10)
            {
                char[] charString = strMessage.ToCharArray();
                string reversedString = String.Empty;
                int lenght, index;
                lenght = charString.Length - 1;
                index = lenght;
                while(index > -1)
                {
                    reversedString = reversedString + charString[index];
                    index--;

                }
                Console.WriteLine(reversedString);
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Please Enter Minimum 3 and Maximum 10 Char, Please Enter to Perfrom again");
                Console.ReadLine();
                goto StringReve;

            }

        }
    }
}
