using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            // Taking User Input
            Console.WriteLine("How many inputs: ");
            int total_input = Convert.ToInt32(Console.ReadLine());     
            
            // Storing into the array                   
            int[] array_num = new int[total_input];

            // Takes total number of input and adds to array
            for (int i = 0; i < total_input; i++)
            {
                Console.Write("Enter the number: ");
                array_num[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sum of an array elements
            int x = 0;
            foreach (int num in array_num)
            {
                 Console.Write("Sum of Array");
                Console.WriteLine(x += num);
            }
        }
    }
}
