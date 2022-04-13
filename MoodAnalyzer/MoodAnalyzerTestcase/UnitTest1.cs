using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTestcase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("null case")]
        public void GivenNullReturnHappyMood()
        {
            ///AAA methodology
            ///arrange
            string message = null;
            string expected = "happy";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string Actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, Actual);
        }
    }
}