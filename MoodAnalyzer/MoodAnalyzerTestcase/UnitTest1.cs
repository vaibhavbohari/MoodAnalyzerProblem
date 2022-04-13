using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTestcase
{
    [TestClass]
    public class UnitTest1
    {
        //Arrangement
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

        [TestMethod]
        public void CheckMoodHappy()
        {
            //Action

            string res = moodAnalyzer.CheckMood("Kunal  is Happy for his new Bike");
           
            //Assert

            Assert.AreEqual("happy", res);
        }
        [TestMethod]
        public void CheckMoodSad()
        {
            //Action

            string res = moodAnalyzer.CheckMood("Kunal  is Sad after getting  fail in exam");
            
            //Assert

            Assert.AreEqual("sad", res);
        }
    }
}

