using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai2_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("1", "one");
            hash.Add("2", "two");
            hash.Add("3", "three");
            //foreach(DictionaryEntry item in hash)
            //{
            //    Console.WriteLine($"{item.Key}\t{item.Value}");
            //}
            Console.WriteLine("Hashtable has already been initialized.\nPlease enter the KEY for searching:");
            object inputKey = Console.ReadLine();
            string strKey = Convert.ToString(inputKey);
            if (hash.ContainsKey(inputKey))
            {
                Console.WriteLine("KEY:\tVALUE:");
                Console.WriteLine();
                Console.WriteLine($"{strKey}\t{hash[strKey]}");
            }
            else
            {
                Console.WriteLine($"The key \"{strKey}\" does not exist in the hashtable.");
            }

            Console.ReadLine();
        }
    }
}
