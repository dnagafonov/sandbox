using System.Collections.Generic;

namespace TryingCollections
{
    public class Instruments
    {
        public static void fillEven(ref List<int> result, ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] != 0)
                {
                    result.Add(arr[i]);
                }
            }
        }
        
        public static void fillOdd(ref List<int> result, ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result.Add(arr[i]);
                }
            }
        }
        
        public static void fillNulls(ref List<int> result, ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    result.Add(arr[i]);
                }
            }
        }

        public static bool firstLessSecond(int a, int b)
        {
            if (a < b && b == a + 1)
            {
                return true;
            }
            return false;
        }
        
        public static bool firstGreaterSecond(int a, int b)
        {
            if (a > b && a == b + 1)
            {
                return true;
            }
            return false;
        }

/*        public static bool arithmeticSequence(int number1, int number2)
        {
            return 
        }*/
    }
}