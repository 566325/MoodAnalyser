using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        private string messege;

        private const string SAD_MESSAGE = "I am in Sad Mood";
        private const string HAPPY_MESSAGE = "I am in Any Mood";
        
        public Mood()
        {

        }
        public Mood(string messege)
        {
            this.messege = messege;
        }
        public string MoodAnalyse()
        {
            try
            {
                if (messege == null || messege == string.Empty)
                    throw new MoodAnalysisException();
                if (messege == SAD_MESSAGE)
                    return "Sad Mood";
                if (messege == HAPPY_MESSAGE)
                    return "Happy Mood";
            }
            catch (MoodAnalysisException)
            {
                return "HAPPY";
            }
            return null;

            //if (messege.ToUpper().Contains("SAD"))
            //{
            //    return "Sad Mood";
            //}
            //else
            //{
            //    return "Happy Mood";
            //}
        }
    }
}
