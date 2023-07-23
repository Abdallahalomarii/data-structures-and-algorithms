using Challenge13_stack_queue_brackets;

namespace TestBrackets
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("()[[Extra Characters]]()",true)]
        [InlineData("{}", true)]
        [InlineData("{}(){}", true)]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("[({}]", false)]
        [InlineData("(](", false)]
        [InlineData("{(})", false)]
        [InlineData(")", false)]
        [InlineData("{", false)]
        [InlineData("[}", false)]
        public void TestAllCases(string value, bool output)
        {
            // Arrange
            bool expected = Program.ValidateBrackets(value);

            Assert.Equal(expected, output);

        }
    }
}