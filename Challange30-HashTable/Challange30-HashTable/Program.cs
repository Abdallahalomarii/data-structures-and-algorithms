using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Challange30_HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            //HashTable<string, string> hashTable = new HashTable<string, string>(10);

            //hashTable.Set("Ahmad", "Civil Engineer");
            //hashTable.Set("Ahmad", "Mechanical Engineer");
            //hashTable.Set("Zaid", "Doctor");
            //hashTable.Set("Mohammad", "CS");
            //hashTable.Set("Bashar", "CIS");
            //hashTable.Set("Anas", "SE");
            //hashTable.Set("Shaker", "Math");
            //hashTable.Set("Abdullah", "Chemistry");
            //hashTable.Set("Yaman", "Physics");
            //hashTable.Set("Said", "CS");

            //Console.WriteLine(hashTable.Get("Ahmad").First());

            //Console.WriteLine(hashTable.Has("Mohammad"));

            //Console.WriteLine(hashTable.HashIndex("Zaid"));

            //hashTable.Print();


            string toFindRepeatedWord1 = "hello abd Ahmad Shaker Ahmad ABD hello Shaker Shaker Ahmad ABD HELLO ";

            string toFindRepeatedWord2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            string toFindRepeatedWord = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            string test = "habcs wert lo";
            Console.WriteLine(HighestRepeatedWord(toFindRepeatedWord1));
            Console.WriteLine(UniqueChar(test));
        }
        public static string RepeatedWord(string value)
        {
            if (value.Length == 0)
            {
                return "Empty string";
            }
            else
            {
                HashTable<string, string> hashTable = new HashTable<string, string>();
                string firstWord = "";
                string result = "";
                string repeatedWord = "";
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]))
                    {
                        result += value[i].ToString().ToLower();
                    }
                    else if (result != "")
                    {
                        firstWord = result;
                        hashTable.Set(result, firstWord);
                        if (hashTable.Get(result).Count() > 1)
                        {
                            repeatedWord = firstWord;
                            break;
                        }
                        result = "";
                    }
                }
                if (repeatedWord == "")
                    return "There was no repeated word in the string you provided";
                else
                    return repeatedWord;
            }
        }

        public static string HighestRepeatedWord(string value)
        {
            if (value.Length == 0)
            {
                return "Empty string";
            }
            else
            {
                HashTable<string, int> hashTable = new HashTable<string, int>();
                int tempCounter = 0;
                string result = "";
                string repeatedWord = "";
                for (int i = 0; i < value.Length; i++)
                {

                    if (char.IsLetter(value[i]))
                    {
                        result += value[i].ToString().ToLower();
                    }
                    else if (result != "")
                    {

                        if (hashTable.Has(result))
                        {
                            var count = hashTable.Get(result).LastOrDefault() + 1;
                            hashTable.Set(result, count);
                            if (count > tempCounter)
                            {
                                tempCounter = count;
                                repeatedWord = result;
                            }
                            else if (tempCounter == count)
                            {
                                repeatedWord = result;
                            }
                        }
                        else
                        {

                            hashTable.Set(result, 1);
                            if (tempCounter == 0)
                            {
                                tempCounter = 1;
                                repeatedWord = result;
                            }
                        }
                        result = "";
                    }
                }

                if (tempCounter == 0)
                    return "There was no repeated word in the string you provided";
                else
                    return repeatedWord;
            }
        }
        public static bool UniqueChar(string value)
        {
            HashTable<char, int> hashTable = new HashTable<char, int>();
            char result;
            for (int i = 0; i < value.Length; i++)
            {

                if (char.IsLetter(value[i]))
                {

                    result = char.ToLower(value[i]);
                    hashTable.Set(result, i);
                    if (hashTable.Get(result).Count() > 1)
                        return false;

                }

            }
            return true;
        }

    }
}
