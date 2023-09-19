using Microsoft.VisualStudio.TestPlatform.TestHost;
using Challange30_HashTable;

namespace TestRepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void IfInputIsEmpty()
        {
            var input = "";
           var result = Challange30_HashTable.Program.RepeatedWord(input);

            var Expected = "Empty string";

            Assert.Equal(Expected, result);
        }

        [Fact]
        public void NoRepeatedWord()
        {
            var input = ":,.'; Hello My Name. Is Abdallah. ,.';:";
            var result = Challange30_HashTable.Program.RepeatedWord(input);

            var expected = "There was no repeated word in the string you provided";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SuccessfullyFoundRepeatedWord()
        {
            var input = ":,.'; Hello My Name. Is Abdallah. ,.';:, And I Have 23 Years old, and I will be 24 this 25 Sep day!";

            var result = Challange30_HashTable.Program.RepeatedWord(input);

            var expected = "And";

            Assert.Equal(expected.ToLower(), result);
        }
    }
}