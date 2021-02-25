using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDiffentyDataTypeGeneric
{
   public class PrintArray
    {
        public void Toprint(int[] inputArray)
        {
            Console.WriteLine("Interge Simple Array");
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        public void Toprint(char[] inputArray)
        {
            Console.WriteLine("char Simple Array");
            foreach (int element in inputArray)
            {
                Console.WriteLine((char)element);
            }
        }
        public void Toprint(double[] inputArray)
        {
            Console.WriteLine("double Simple Array");
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            } 
        }
        public void Toprint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
