using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T> where T : IComparable
    {
        #region Before Genarics
        //public static void SWAP(ref object X, ref object Y)
        //{
        //    Console.WriteLine("After Swap");
        //    object Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    Console.WriteLine("After Swap");
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Console.WriteLine("After Swap");
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        #endregion

        #region After Generics 

        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

        //public static int SearchArray(int[] Arr, int value)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (value == Arr[i])
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}




        public static int SearchArray(T[] Arr, T value)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (value.Equals(Arr[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        #region BubbleSort

        public static void BubbleSort(T[] Array)
        {
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - i - 1; j++)
                    {
                        //if (Array[j] > Array[j + 1])
                        if (Array[j].CompareTo(Array[j + 1]) == 1)
                            Helper<int>.SWAP(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
        }
        #endregion

        #region Generic Constrains
        /* Generics Constrains:

          1- Primary
               1- General 0 - 1
                  1- class 
                  2- Struct
                  3- Not Null must be not nullable --> C#8
                  4- Enum --> C#7 (General Type)

               2- Special 
                  1- User Defiened class (except sealed --> No inherit)

         2- Secondary 
                1- interface constraints 0 - M
                ICombarable<T>  
                T must be class or struct implmenting iComparable

         3- Constructor 
            paramtrless    0 - 1
            Must be data type having acceccible [ non - private ]
            till C#12 Only one
            cannot use new() [ Constructor Constraint with struct special primary constrain ]

        */
        #endregion




    }
}
