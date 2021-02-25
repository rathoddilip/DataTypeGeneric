using System;

namespace ArrayDiffentyDataTypeGeneric
{
 class Program
    {
        static void Main(string[] args)
        {
            PrintArray printArray= new PrintArray();
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = {10.1D, 20.2D, 30.3D, 40.4D, 50.5D };
            char[] charArray = { 'W', 'E', 'L', 'C', 'O', 'M', 'E' };
            //Simple Method Array 
            printArray.Toprint(intArray);
            printArray.Toprint(doubleArray);
            printArray.Toprint(charArray);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Generic Method Array");
            printArray.Toprint<int>(intArray);
            printArray.Toprint<double>(doubleArray);
            printArray.Toprint<char>(charArray);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Generic Class Array");
            new GenericClass<int>(intArray).ToPrint();
            new GenericClass<double>(doubleArray).ToPrint();
            new GenericClass<char>(charArray).ToPrint();
            Console.ReadLine();
        }
    }
}
