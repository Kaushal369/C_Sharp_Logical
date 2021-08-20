using System;
using System.Collections.Generic;
using System.Text;

namespace webApp
{
    class arrayExample
    {

        static void Main(string[] args)
        {

            int[] arr = new int[10];
            int i;
            for (i = 0; i <arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.WriteLine(arr[i]);
            }
            
            Console.ReadLine();

        }


    }
}
