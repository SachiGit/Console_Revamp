using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Revamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello Sachi...");  //New line added  
            byte number = 3;
            int count = 10;
            double price = 12.09;
            float max = 22.543f;
            char character = 'A';
            string firstName = "Sachi";
            bool test = true;*/
            //decimal totalPrice = 20.95m;

            //var testVar = 222;

            /*Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(max);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(test);*/

            /*byte b = 100; // byte to int
            int c = b;
            Console.WriteLine(c);

            int a = 5;
            byte e = (byte)a;
            Console.WriteLine(e);


            try
            {
                //var v = "4321";
                //byte bt = Convert.ToByte(v);
                //Console.WriteLine(bt);

                string str = "true";
                bool b1 = Convert.ToBoolean(str);
                Console.WriteLine(b1);
            }

            catch (Exception)
            {
                Console.WriteLine("Error, the number could not converted to Byte");
                //throw;
            }*/

            var c = 65;
            var d = c;
            d++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", c, d));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 99;

            Console.WriteLine(string.Format ("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));



        }

    }
}
