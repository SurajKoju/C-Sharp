using System;

namespace Swap{
    class Swap_number{

        public static void Swap(int a, int b){
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("First Number = " + a + " Second Number = " + b);
        }
        static void Main(string[] args){
            Console.Write("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Swap(a, b);
        }
    }
}