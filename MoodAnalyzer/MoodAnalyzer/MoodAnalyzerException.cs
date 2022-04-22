﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException:Exception 
    {
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION
        }
        public readonly ExceptionType type;
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
    

