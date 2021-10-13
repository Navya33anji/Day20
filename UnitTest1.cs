using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMethodAnalyseMoodsad()
        {
            string expect = "sad";
            string actual;
            Uc1MoodAnalyzer.MoodAnalyser mood = new Uc1MoodAnalyzer.MoodAnalyser();
            actual = mood.AnalyseMood("I am in sad mood");

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethodAnalyseMoodHappy()
        {
            string expect = "happy";
            string actual;

            UC1MoodAnalyzer.MoodAnalyser mood = new UC1MoodAnalyzer.MoodAnalyser();
            actual = mood.AnalyseMood("I am in happy mood");

            Assert.AreEqual(expect, actual);

        }
    }
}
