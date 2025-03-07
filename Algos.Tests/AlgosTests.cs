namespace Algos.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       
        [TestCase("abc", ExpectedResult = "cba")]
        [TestCase("hello", ExpectedResult = "olleh")]
        [TestCase("world", ExpectedResult = "dlrow")]
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("", ExpectedResult = "")]
        public string ReverseStringTest(string a)
        {
            return ReverseStringSolution.ReverseString(a);
        }

        [TestCase("abc", ExpectedResult = "cba")]
        [TestCase("hello", ExpectedResult = "olleh")]
        [TestCase("world", ExpectedResult = "dlrow")]
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("", ExpectedResult = "")]
        public string ReverseStringTest_v2(string a)
        {
            return ReverseStringSolution.ReverseString_v2(a);
        }

        [TestCase("abc", ExpectedResult = "cba")]
        [TestCase("hello", ExpectedResult = "olleh")]
        [TestCase("world", ExpectedResult = "dlrow")]
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("", ExpectedResult = "")]
        public string ReverseStringTest_v3(string a)
        {
            return ReverseStringSolution.ReverseString_v3(a);
        }


        [TestCase("[abc]", ExpectedResult = true)]
        [TestCase("][hello][", ExpectedResult = false)]
        [TestCase("[[[wor]l]d]]", ExpectedResult = false)]
        [TestCase("[[[wor]l]d]", ExpectedResult = true)]
        [TestCase("a", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        public bool BracesPairsTest(string a)
        {
            return BracesPairsSolution.IsStringWithBracesValid(a);
        }

        [TestCase(new char[] { 'a', 'a', 'b' }, ExpectedResult = 3)]
        [TestCase(new char[] { 'a', 'b', 'b', 'b' }, ExpectedResult = 3)]
        [TestCase(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, ExpectedResult = 6)]
        [TestCase(new char[] { 'a' }, ExpectedResult = 1)]
        public int CompressStringTest(char[] chars)
        {
            return CompressString.Compress(chars);
        }

        [TestCase(new char[] { 'a', 'a', 'b' }, ExpectedResult = 3)]
        [TestCase(new char[] { 'a', 'b', 'b', 'b' }, ExpectedResult = 3)]
        [TestCase(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, ExpectedResult = 6)]
        [TestCase(new char[] { 'a' }, ExpectedResult = 1)]
        public int CompressStringTest1(char[] chars)
        {
            return CompressString.Compress_v2(chars);
        }

        [TestCase("()", ExpectedResult = true)]
        public bool ValidParenthesesTest(string a)
        {
            return ValidParenthesesSolution.IsValid(a);
        }

        [TestCase("3[a]2[bc]", ExpectedResult = "aaabcbc")]
        [TestCase("3[a2[c]]", ExpectedResult = "accaccacc")]
        public string DecodeStringTest(string a)
        {
            return DecodeStringSolution.DecodeString_v2(a);
        }
    }
}