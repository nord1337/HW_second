using System;
using HWbars;
namespace HW_BubbleSortLIb
{
    class Program
    {
        static void Print (params int [] allparams)
        {
            foreach(int param in allparams)
            {
                Console.Write(param.ToString() + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[10] { 2,10,25,7,11,22,9,5,4,3};
            Print(array);
            BubbleSortLib.sort(array);
            Print(array);

        }
    }
}
