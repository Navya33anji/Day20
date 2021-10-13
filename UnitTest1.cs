using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethodAnyMood()
        {
            string expectedoutput = "happy";
            string actualoutput;
            UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser("Today I am any mood");

            actualoutput = mood.AnalyseMood();

            Assert.AreEqual(expectedoutput, actualoutput);

        }
        [TestMethod]
        public void TestMethodsadMood()
        {
            string expectedoutput = "sad";
            string actualoutput;
            UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser("Today I am sad mood");

            actualoutput = mood.AnalyseMood();

            Assert.AreEqual(expectedoutput, actualoutput);

        }
        [TestMethod]
        [DataRow(null)]
        public void TestMethodNull(string msg)
        {
            string expectedoutput = "happy";
            string actualoutput;
            UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser(msg);

            actualoutput = mood.AnalyseMood();

            Assert.AreEqual(expectedoutput, actualoutput);

        }
    }
}
