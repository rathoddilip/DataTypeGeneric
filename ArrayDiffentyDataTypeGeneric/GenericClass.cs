using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDiffentyDataTypeGeneric
{
   public class GenericClass<T>
    {
         T[] inputArray;
        public GenericClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void ToPrint()
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

    }
}
