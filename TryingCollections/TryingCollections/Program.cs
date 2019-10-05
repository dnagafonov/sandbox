using System;
using System.Collections;
using System.Collections.Generic;

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
    class Program
    {
        static void Main(string[] args)
        {
            TryingDictionary names = new TryingDictionary();
            names.fillName(1,"Vanya");
            names.fillName(2,"Danya");
            names.fillName(3,"Olya");
            names.fillName(4,"Valik");
            names.getCurrentNeme(3);
        }
    }
}