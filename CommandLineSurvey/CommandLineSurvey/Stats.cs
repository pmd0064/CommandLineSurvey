using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineSurvey
{
    class Stats
    {
        public void Start()
        {
            Program.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey posted, runt stats");
        }
    }
}
