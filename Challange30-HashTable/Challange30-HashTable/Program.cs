
using System.Runtime.InteropServices;

namespace Challange30_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable<string,string> hashTable = new HashTable<string, string>(10);

            hashTable.Set("Ahmad", "Civil Engineer");
            hashTable.Set("Ahmad", "Mechanical Engineer");
            hashTable.Set("Zaid", "Doctor");
            hashTable.Set("Mohammad", "CS");
            hashTable.Set("Bashar", "CIS");
            hashTable.Set("Anas", "SE");
            hashTable.Set("Shaker", "Math");
            hashTable.Set("Abdullah", "Chemistry");
            hashTable.Set("Yaman", "Physics");
            hashTable.Set("Said", "CS");

            Console.WriteLine(hashTable.Get("Ahmad").First());

            Console.WriteLine(hashTable.Has("Mohammad"));

            Console.WriteLine(hashTable.HashIndex("Zaid"));

            hashTable.Print();
        }
    }
}
