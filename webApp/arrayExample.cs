using System;
using System.Collections.Generic;
using System.Text;

namespace webApp
{
    class arrayExample
    {

        static void Main(string[] args)
        {
            // To Print 1 t0 nth value 
            try
            {
                Console.WriteLine("Enter the number want to print upto");
                int num = Int32.Parse(Console.ReadLine());
                int[] arr = new int[num];
                int i;
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("-----------------------------------------------------");
                Console.ReadLine();
               
            }

            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program is End !!!!!!!!!");
            
            }
            
        }

    }
}
