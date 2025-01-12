using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper
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
    }
}
