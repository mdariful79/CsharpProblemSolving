using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExGeneric
{
    public class ExBubbleSort<T> where T : INumber<T>
    {
        public T[] Sort(T[] number)
        {
            bool flag = true;
            T temp;
            int numLength = number.Length;

            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            return number;
        }

    }
}
