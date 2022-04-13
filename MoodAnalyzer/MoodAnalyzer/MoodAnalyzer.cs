using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public enum Mood
    {
        Happy,
        sad
    }

    public class MoodAnalyzer
    {
        public string CheckMood(string msg)
        {
            //msg : Kunal  is Happy for his new Bike
            //msg : Kunal  is Sad after getting  fail in exam
          
            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }


}
