using System;

namespace Table{
    class Multiply{
        public static void Table(int a){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(a + " X " + i + " = " + (a * i));
            }
        }

        static void Main(string[] args){
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Table(a);
        }
    }
}