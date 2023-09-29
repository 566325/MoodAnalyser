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
        public Mood()
        {

        }
        public Mood(string messege)
        {
            this.messege = messege;
        }
        public string MoodAnalyse()
        {
            if (messege.ToUpper().Contains("SAD"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }
        }
    }
}
