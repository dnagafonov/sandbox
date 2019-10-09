using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static TryingCollections.Instruments;

namespace TryingCollections
{
    public class Tuple
    {
        private Object[] _objects;

        public Tuple()
        {
            _objects = new Object[1];
        }

        public Tuple(ICollection a)
        {
            
        }

    }
    class TryingDictionary
    {
        private Dictionary<int,string> names;

        public TryingDictionary()
        {
            names = new Dictionary<int, string>();
        }
        public void fillName(int id, string name)
        {
            try
            {
                names.Add(id, name);
            }
            catch
            {
                Console.WriteLine("Элемент с ключом " + id + " уже существует");
            }
        }

        public void getCurrentNeme(int id)
        {
            Console.WriteLine(names[id]);
        }

        public void getNames()
        {
            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Arrays
    {
        public static void task_3_3()
        {
            int[] arr1 = new[] {1, 2, 3, 4, 3};
            int[] arr2 = new[] {2, 3, 4, 1, 5};
            int[] res = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(res,0);
            arr2.CopyTo(res, arr1.Length);
            Array.Sort(res);
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void task_3_4()
        {
            int[] arr1 = new[] {1, 1, 3, 4, 5};
            int[] arr2 = new[] {1, 2, 3, 4, 5};
            HashSet<int> res = new HashSet<int>();
            for (int i = 0; i != arr1.Length; ++i)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        res.Add(arr1[i]);
                    }
                }
            }

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void task_3_5()
        {
            int[] arr1 = new[] {1, 2, 3, 4, 5, 6};
            int[] arr2 = new[] {1, 2, 3, 4, 5};
            SortedSet<int> res = new SortedSet<int>(arr1.Union(arr2));
            for(int i = 0; i != arr1.Length)
        }

        public static void task_3_6()
        {
            int[] arr = new[] {0,1,2,3,4,5,6};
            List<int> result = new List<int>(arr.Length);
            Instruments.fillEven(ref result, ref arr);
            Instruments.fillOdd(ref result, ref arr);
            Instruments.fillNulls(ref result, ref arr);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static void task_3_10()
        {
            int[] arr = new[] {1,1,1,1,3,3,3,3,3,3,4};
            Dictionary<int,int> result = new Dictionary<int, int>();
            int currentSize = 0;
            for (int i = 0; i < arr.Length; i++) // error
            {
                i += currentSize;
                if (arr[i+currentSize] == arr[i + currentSize + 1])
                {
                    int counter = 1;
                    int el = arr[i + currentSize];
                    
                    for (int j = i + currentSize; el == arr[j]; j++)
                    {
                        counter++;
                    }
                    
                    currentSize += counter;
                    result.Add(i,counter);
                }
            }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static void task_3_11()
        {
            int[] arr = new[] {1, 2, 3, 4, 5};
            
        }

        public static void task_2_6_1()
        {
            int[] arr = new[] {2,3,5,1,6,5,4,3};
            int counter = 1;
            for (int i = 0; i != arr.Length - 1; ++i)
            {
                if (arr[i] < arr[i+1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        
        public static void task_2_6_2()
        {
            int[] arr = new[] {2,3,5,1,6,5,4,3};
            int counter = 1;
            for (int i = 0; i != arr.Length - 1; ++i)
            {
                if (arr[i] > arr[i+1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        
        public static void task_2_6_3()
        {
            int[] arr = new[] {2,3,5,1,6,5,4,3};
            int counter = 1;
            for (int i = 0; i != arr.Length - 1; ++i)
            {
                if (arr[i] > arr[i+1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        public static void t36()
        {
            int[] arr1 = new[] {1, 2, 3, 4, 5};
            int[] arr2 = new[] {6, 7, 8, 9, 1};
            SortedSet<int> arr = new SortedSet<int>();
            for (int i = 0; i != arr1.Length; ++i)
            {
                for (int j = 0; j != arr2.Length; ++j)
                {
                    if (arr1[i] != arr2[j])
                    {
                        
                    }
                }
            }
        }
        
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            TryingDictionary names = new TryingDictionary();
            names.fillName(1,"Vanya");
            names.fillName(2,"Danya");
            names.fillName(3,"Olya");
            names.fillName(4,"Valik");
            //names.getCurrentNeme(3);
            //Arrays.task_3_10();
/*            for (int i = 0; i < 10; i++)
            {
                Console.Beep(300,500);
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
*/
            Arrays.task_3_5();
            //Arrays.task_2_6_1();
        }
    }
}