﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyzerProblem 
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am happy");
            moodAnalyzer.AnalyzeMood();
        }
    }
}