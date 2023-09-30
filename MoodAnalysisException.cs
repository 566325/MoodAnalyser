using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        public enum Errors { EMPTY }
        public MoodAnalysisException()
        {
            Console.WriteLine(Errors.EMPTY);
        }
    }
}
