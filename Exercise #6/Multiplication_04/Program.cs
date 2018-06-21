using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int doubling_up;
            Console.WriteLine("Enter a number you want multiplication table for:");
            input = Convert.ToInt32(Console.ReadLine());
            doubling_up =  DisplayMultiplicationTable(input);
            Console.WriteLine("The number you entered was {0}", input);
           // Console.WriteLine("The doubled input is {0}", doubling_up);



        }


        private static int DisplayMultiplicationTable(int input) {

            
            int beginningValue = 2;
            int endingValue = 10;
            


            for(int i = beginningValue;i <= endingValue; i++)
            {
                int multiply = input * i;
                string spacing = "    ";//4 spaces
                string extra_spacing = "     ";//5 spaces
                if (i < 10)
                {
                    Console.Write(i + extra_spacing + multiply + "\n");


                }
                else
                {


                    Console.Write(i + spacing + multiply + "\n");
                }

                    



            }






















            return 0;
        }
    }
}
