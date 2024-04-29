using UtilityLibraries;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void 大文字で始まる文字列はTrueを返すか()
    {
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
        foreach (string word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsTrue(result, string.Format("Expected for '{0}': true; Actual: {1}", word, result));
        }
    }

    [TestMethod]
    public void 小文字で始まる文字列はFalseを返すか()
    {
        // Tests that we expect to return false.
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };
        foreach (string word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result, string.Format("Expected for '{0}': true; Actual: {1}", word, result));
        }
    }

    [TestMethod]
    public void 空文字やNullの場合はFalseを返すか()
    {
        string?[] words = { string.Empty, null };
        foreach (string word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}", word == null ? "<null>" : word, result));
        }
    }
}