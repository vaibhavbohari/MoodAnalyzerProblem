using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;  //instance variable
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        //uc-2 handling exceptions
        public string AnalyzeMood()    //Analyzer method find mood
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }

        }
    }
}





   