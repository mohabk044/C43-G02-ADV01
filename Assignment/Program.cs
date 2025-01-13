using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            // Optimized Bubble Sort
            Console.WriteLine("=== Optimized Bubble Sort ===");
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            OptimizedBubbleSort.BubbleSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));



            // Range<T>
            Console.WriteLine("\n=== Range<T> ===");
            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine("Is 15 in range: " + intRange.IsInRange(15));
            Console.WriteLine("Range length: " + intRange.Length());

        }
    }
}
