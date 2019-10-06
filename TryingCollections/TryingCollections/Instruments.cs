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
    }
}