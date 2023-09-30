using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        public string messege;

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
                    throw new Exception();
                if (messege == SAD_MESSAGE)
                    return "SAD";
                if (messege == HAPPY_MESSAGE)
                    return "HAPPY";
            }
            catch (Exception)
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
