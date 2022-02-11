using NUnit.Framework;

namespace WordleKata
{
    [TestFixture]
    public class Tests
    {
        private WordService _wordService;
        
        [SetUp]
        public void Setup()
        {
            _wordService = new WordService();
        }
        
        [Test]
        public void TestThatWordIsFiveLetterWord()
        {
            var word = _wordService.GetRandomWord();
            Assert.AreEqual(5, word.Length);
        }
    }
}