using System;
using System.Collections.Generic;
using System.Text;

namespace Uc1MoodAnalyserException
{
   public class MoodAnalyser
    {
        internal static MoodAnalyser.moodAnalyser moodAnalyser;

        public class Program
        {
            public string AnalyseMood(string msg)
            {
                if (msg.ToLower().Contains("Happy"))
                {
                    return "Happy";
                }
                else if (msg.ToLower().Contains("any"))
                {
                    return "Any";
                }
                else
                {
                    return "Sad";
                }
            }
        }

        
    }
}
