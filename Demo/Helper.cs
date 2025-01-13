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






    }
}
