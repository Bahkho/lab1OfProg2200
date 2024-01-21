using System;
using System.Collections.Generic;
using System.Text;

namespace challenge10
{
    class Marketing
    {
        public void SubscribeToSurvey()
        {
            Program.Posted += SurveyCompleted;
        }

        void SurveyCompleted()
        {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    }

}