using Challange30_HashTable;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace HashTableTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfItAddToTheHashMapAndToCheckIfItReturnTheKeyValue()
        {
            var hashTable = new HashTable<string, string>(1);

            hashTable.Set("SE", "Abdallah");

            var keys = hashTable.Keys();

            Assert.Contains("SE", keys);
            Assert.Equal(0, hashTable.HashIndex("SE"));

        }

        [Fact]
        public void SuccessfullyReturnNullIfKeyNotExist()
        {
            var hashTable = new HashTable<string, string>();

            Assert.Throws<KeyNotFoundException>(() => hashTable.Get("SE"));

            Assert.False(hashTable.Has("SE"));
        }

        [Fact]
        public void ReturnsAListOfAllUniqueKeys()
        {
            var hashTable = new HashTable<string, string>();

            hashTable.Set("Zaid", "Doctor");
            hashTable.Set("Mohammad", "CS");

            var keys = hashTable.Keys();

            var list = keys.ToList();

            var expectedList = new List<string>();
            expectedList.Add("Mohammad");
            expectedList.Add("Zaid");
            Assert.Equal(expectedList, list);

        }

        [Fact]
        public void HandleCollisionInHashAndRetrieveTheExactBucket()
        {
            var hashTable = new HashTable<string, string>();

            hashTable.Set("Zaid", "Doctor");
            hashTable.Set("Zaid", "CS");

            var list = new List<string>();

            list.Add("Doctor");
            list.Add("CS");

            Assert.Equal(list, hashTable.Get("Zaid"));

        }
        [Fact]
        public void InRangeOfHashTable()
        {
            var hashTable = new HashTable<string, string>();

            hashTable.Set("Zaid", "Doctor");

            var hashIndex = hashTable.HashIndex("Zaid");

            Assert.True(hashIndex >= 0 && hashIndex < hashTable.Map.Length);
        }

    }
}